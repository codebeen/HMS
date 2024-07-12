using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HOTEL_MANAGEMENT_SYSTEM.UI;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class PaymentUtility
    {
        private readonly string apiKey = "sk_test_ZUDfSutGxhHPUTfHht7ydjSK"; // Secret key
        private readonly HttpClient client;

        // In-memory storage for payment IDs
        private static Dictionary<string, string> paymentIds = new Dictionary<string, string>();

        public PaymentUtility()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
        }

        public async Task<string> CreateGCashSource(decimal amount, string currency)
        {
            var json = new JObject
            {
                { "data", new JObject
                    {
                        { "attributes", new JObject
                            {
                                { "amount", (int)(amount * 100) }, // Amount in centavos room
                                { "currency", currency },
                                { "type", "gcash" },
                                { "billing", new JObject
                                    {
                                        { "email", "juan@paymongo.com" },
                                        { "name", "Juan Dela Cruz" },
                                        { "phone", "09168268582" }
                                    }
                                },
                                { "redirect", new JObject
                                    {
                                        { "success", "https://mysite.com/gcash/success" }, // Specify form redirection
                                        { "failed", "https://mysite.com/gcash/failed" }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            MessageBox.Show(json.ToString());

            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            MessageBox.Show(content.ToString());
            var response = await client.PostAsync("https://api.paymongo.com/v1/sources", content);
            MessageBox.Show(response.ToString());
            var responseContent = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseContent.ToString());
            if (!response.IsSuccessStatusCode)
            {
                // Log the response content for debugging
                Console.WriteLine("Error: " + responseContent);
                throw new Exception("Error: " + responseContent);
            }

            var responseObject = JObject.Parse(responseContent);
            MessageBox.Show(responseObject.ToString());
            // Extract the payment ID from the response
            string paymentId = responseObject["data"]["id"].ToString();
            MessageBox.Show(paymentId.ToString());
            // Extract the checkout URL from the response
            string checkoutUrl = responseObject["data"]["attributes"]["redirect"]["checkout_url"].ToString();

            string status = responseObject["data"]["attributes"]["status"].ToString();
            MessageBox.Show(status.ToString());

            // Save the paymentId for future status checking
            SavePaymentId("lastPaymentId", paymentId); // Using a key to identify the paymentId

            return checkoutUrl;
        }

        public static void SavePaymentId(string key, string paymentId)
        {
            paymentIds[key] = paymentId;
        }

        public static string GetPaymentId(string key)
        {
            if (paymentIds.TryGetValue(key, out string paymentId))
            {
                return paymentId;
            }
            else
            {
                return null; // Or throw an exception as needed
            }
        }

        public async Task<string> CheckPaymentStatus(string paymentId)
        {
            try
            {
                var response = await client.GetAsync($"https://api.paymongo.com/v1/payments/{paymentId}");
                MessageBox.Show(response.ToString());
                response.EnsureSuccessStatusCode();
                MessageBox.Show(response.ToString());

                var responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseContent.ToString());
                dynamic responseObject = JObject.Parse(responseContent);
                MessageBox.Show(responseObject.ToString());

                // Ensure the structure of the JSON response before accessing nested properties
                if (responseObject["data"] != null &&
                    responseObject["data"]["attributes"] != null &&
                    responseObject["data"]["attributes"]["status"] != null)
                {
                    string status = responseObject["data"]["attributes"]["status"].ToString();
                    MessageBox.Show(status.ToString());
                    return status;
                }
                else
                {
                    // Handle unexpected JSON structure
                    throw new Exception("Invalid JSON structure in API response");
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request errors
                throw new Exception($"HTTP request error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other unexpected errors
                throw new Exception($"Error checking payment status: {ex.Message}");
            }
        }

        // Assume you have a PayMongoApiClient class as shown in the previous messages
        public async Task<string> ProcessPayment(decimal amount, string currency, string cardNumber, int expMonth, int expYear, string cvc)
        {
            // Step 1: Create Payment Method
            var paymentMethodId = await CreatePaymentMethod(cardNumber, expMonth, expYear, cvc);

            // Step 2: Create Payment Intent
            var paymentIntentResponse = await CreatePaymentIntent(amount, currency, paymentMethodId);

            // Return payment intent response (you would handle this response accordingly)
            return paymentIntentResponse;
        }

        public async Task<string> CreatePaymentMethod(string cardNumber, int expMonth, int expYear, string cvc)
        {
            try
            {
                var request = new
                {
                    data = new
                    {
                        attributes = new
                        {
                            type = "card",
                            details = new
                            {
                                card_number = cardNumber,
                                exp_month = expMonth,
                                exp_year = expYear,
                                cvc = cvc
                            },
                            billing = new
                            {
                                address = new
                                {
                                    city = "Taguig",
                                    country = "PH",
                                    line1 = "Unit 3308, High St South Corp Plaza",
                                    line2 = "26th Street & 11th Avenue",
                                    postal_code = "1634",
                                    state = "Metro Manila"
                                },
                                email = "juan@paymongo.com",
                                name = "Juan Dela Cruz",
                                phone = "63288881111"
                            }
                        }
                    }
                };

                var jsonContent = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.paymongo.com/v1/payment_methods", content);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(responseContent);

                string paymentMethodId = responseObject.data.id;
                return paymentMethodId;
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exception
                Console.WriteLine($"HTTP request error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<string> CreatePaymentIntent(decimal amount, string currency, string paymentMethodId)
        {
            try
            {
                var request = new
                {
                    amount = (int)(amount * 100), // Convert amount to cents
                    currency = currency,
                    payment_method = paymentMethodId
                    // You can add more attributes as required by PayMongo API
                };

                var jsonContent = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.paymongo.com/v1/payment_intents", content);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(responseContent);

                string paymentIntentId = responseObject.data.id;
                return paymentIntentId;
            }
            catch (HttpRequestException ex)
            {
                // Handle HTTP request exception
                Console.WriteLine($"HTTP request error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
