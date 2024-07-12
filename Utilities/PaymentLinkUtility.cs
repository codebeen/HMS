using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Utilities
{
    public class PaymentLinkUtility
    {
        private readonly string apiKey = "sk_test_ZUDfSutGxhHPUTfHht7ydjSK"; // Replace with your actual API key

        public async Task<string> CreatePaymentLink(decimal amount, string description, string remarks)
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
                            remarks = remarks
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

        public async Task<string> CheckPaymentStatus(string linkId)
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

        public async Task<string> WaitForPaymentStatus(string linkId)
        {
            string status = "unpaid";
            while (status != "paid" && status != "failed")
            {
                status = await CheckPaymentStatus(linkId);
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
    }
}

