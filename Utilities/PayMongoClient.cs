using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class PayMongoClient
    {
        private readonly RestClient client;
        private readonly string apiKey = "sk_test_ZUDfSutGxhHPUTfHht7ydjSK"; // Replace with your actual API key


        public PayMongoClient()
        {
            var options = new RestClientOptions
            {
                BaseUrl = new Uri("https://api.paymongo.com/v1/"),
                Authenticator = new HttpBasicAuthenticator(apiKey, "")
            };

            client = new RestClient(options);
        }
        // GCash Payment Link web
        public async Task<string> CreateGCashPaymentLink(decimal amount, string description)
        {
            try
            {
                var client = new RestClient("https://api.paymongo.com/v1/links");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
                request.AddHeader("Content-Type", "application/json");

                var body = new
                {
                    data = new
                    {
                        attributes = new
                        {
                            amount = amount,
                            description = description,
                            remarks = "G-Cash Payment"
                        }
                    }
                };

                request.AddJsonBody(body);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var responseData = JObject.Parse(response.Content);
                    string linkId = responseData["data"]["id"].ToString();
                    string checkoutUrl = responseData["data"]["attributes"]["checkout_url"].ToString();
                    return checkoutUrl;
                }
                else
                {
                    Console.WriteLine("Failed to create GCash payment link: " + response.Content);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        // PayMaya Payment Link web
        public async Task<string> CreatePayMayaPaymentLink(decimal amount, string description)
        {
            try
            {
                var apikey = "sk_test_ZUDfSutGxhHPUTfHht7ydjSK";

                var client = new RestClient("https://api.paymongo.com/v1/links");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apikey)));
                request.AddHeader("Content-Type", "application/json");

                var body = new
                {
                    data = new
                    {
                        attributes = new
                        {
                            amount = amount,
                            description = description,
                            remarks = "PayMaya Payment"
                        }
                    }
                };

                request.AddJsonBody(body);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var responseData = JObject.Parse(response.Content);
                    string linkId = responseData["data"]["id"].ToString();
                    string checkoutUrl = responseData["data"]["attributes"]["checkout_url"].ToString();
                    return checkoutUrl;
                }
                else
                {
                    Console.WriteLine("Failed to create PayMaya payment link: " + response.Content);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
        // E-Wallet Payment Status Checker
        public async Task<string> WaitForPaymentStatus(string linkId)
        {
            string status = "unpaid";
            while (status != "paid" && status != "failed")
            {
                status = await CheckPaymentStatusEWallet(linkId);
                if (status == null)
                {
                    Console.WriteLine("Failed to check payment status.");
                    break;
                }

                Console.WriteLine("Current payment status: " + status);
                await Task.Delay(5000); // Wait for 5 seconds before checking again
            }

            Console.WriteLine("Final payment status: " + status);
            return status;
        }
        // Payment Status Checker for EWallet
        public async Task<string> CheckPaymentStatusEWallet(string linkId)
        {
            try
            {
                var client = new RestClient($"https://api.paymongo.com/v1/links/{linkId}");
                var request = new RestRequest("", Method.Get);
                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var responseData = JObject.Parse(response.Content);
                    string status = responseData["data"]["attributes"]["status"].ToString();
                    return status;
                }
                else
                {
                    Console.WriteLine("Failed to retrieve payment link details: " + response.Content);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // useless
        public async Task<string> CreatePaymentLink(decimal amount, string description, string remarks)
        {
            try
            {
                var client = new RestClient("https://api.paymongo.com/v1/links");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
                request.AddJsonBody(new
                {
                    data = new
                    {
                        attributes = new
                        {
                            amount = amount,
                            description = description,
                            remarks = remarks
                        }
                    }
                });

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var responseData = JObject.Parse(response.Content);
                    string linkId = responseData["data"]["id"].ToString();
                    return linkId;
                }
                else
                {
                    Console.WriteLine("Failed to create payment link: " + response.Content);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // useless
        public async Task<string> AccessAndCheckPayment(string linkId)
        {
            try
            {
                var client = new RestClient($"https://api.paymongo.com/v1/links/{linkId}");
                var request = new RestRequest("", Method.Get);
                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));

                string checkoutUrl = null;
                string status = "unpaid";

                while (status != "paid" && status != "failed")
                {
                    var response = await client.ExecuteAsync(request);

                    if (response.IsSuccessful)
                    {
                        var responseData = JObject.Parse(response.Content);
                        status = responseData["data"]["attributes"]["status"].ToString();
                        checkoutUrl = responseData["data"]["attributes"]["checkout_url"].ToString();
                    }
                    else
                    {
                        Console.WriteLine("Failed to retrieve payment link details: " + response.Content);
                        break;
                    }

                    await Task.Delay(5000); // Wait for 5 seconds before checking again
                }

                return checkoutUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public async Task<string> CreatePaymentMethod(string bankName, string cardNumber, int expMonth, int expYear, string cvc)
        {
            var client = new RestClient("https://api.paymongo.com/v1/payment_methods");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
            request.AddHeader("Content-Type", "application/json");

            var paymentMethodBody = new
            {
                data = new
                {
                    attributes = new
                    {
                        type = "card",
                        details = new
                        {
                            bank_code = bankName,
                            card_number = cardNumber,
                            exp_month = expMonth,
                            exp_year = expYear,
                            cvc = cvc
                        },
                        billing = new
                        {
                            address = new
                            {
                                line1 = "Unit 3308, High St South Corp Plaza",
                                line2 = "26th Street & 11th Avenue",
                                city = "Taguig",
                                state = "Metro Manila",
                                postal_code = "1634",
                                country = "PH"
                            },
                            name = "Juan Dela Cruz",
                            email = "juan@paymongo.com",
                            phone = "63288881111"
                        }
                    }
                }
            };

            request.AddJsonBody(paymentMethodBody);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var responseData = JObject.Parse(response.Content);
                var paymentMethodId = responseData["data"]["id"].ToString();
                return paymentMethodId;
            }
            else
            {
                var responseData = JObject.Parse(response.Content);
                var errorDetail = responseData["errors"][0]["detail"].ToString();

                return null;
            }
        }


        public async Task<string> CreatePaymentIntent(decimal amount)
        {
            var client = new RestClient("https://api.paymongo.com/v1/payment_intents");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
            request.AddHeader("Content-Type", "application/json");

            var paymentIntentBody = new
            {
                data = new
                {
                    attributes = new
                    {
                        amount = amount, // Example amount
                        currency = "PHP",
                        payment_method_allowed = new[] { "card" },
                        payment_method_options = new
                        {
                            card = new
                            {
                                request_three_d_secure = "any"
                            }
                        },
                        description = "Example payment"
                    }
                }
            };

            request.AddJsonBody(paymentIntentBody);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var responseData = JObject.Parse(response.Content);
                var paymentIntentId = responseData["data"]["id"].ToString();
                return paymentIntentId;
            }
            else
            {
                MessageBox.Show("Failed to create payment intent: " + response.Content);
                return null;
            }
        }

        public async Task<bool> AttachPaymentMethodToIntent(string paymentIntentId, string paymentMethodId)
        {
            var client = new RestClient($"https://api.paymongo.com/v1/payment_intents/{paymentIntentId}/attach");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));
            request.AddHeader("Content-Type", "application/json");

            var attachBody = new
            {
                data = new
                {
                    attributes = new
                    {
                        payment_method = paymentMethodId
                    }
                }
            };

            request.AddJsonBody(attachBody);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var responseData = JObject.Parse(response.Content);
                return true;
            }
            else
            {
                MessageBox.Show("Failed to attach payment method: " + response.Content);
                return false;
            }
        }

        public async Task<string> CheckPaymentStatus(string paymentIntentId)
        {
            var client = new RestClient($"https://api.paymongo.com/v1/payment_intents/{paymentIntentId}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("accept", "application/json");
            request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(apiKey)));

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var responseData = JObject.Parse(response.Content);
                var status = responseData["data"]["attributes"]["status"].ToString();
                return status;
            }
            else
            {
                MessageBox.Show("Failed to check payment status: " + response.Content);
                return null;
            }
        }
    }
}
