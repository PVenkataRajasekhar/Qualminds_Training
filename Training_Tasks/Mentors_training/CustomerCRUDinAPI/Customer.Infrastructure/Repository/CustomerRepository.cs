using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Core.Repository;
using Customer.Core.Model;
using Customer.Infrastructure.Context;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using Polly;
using Polly.Retry;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace Customer.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerCrudDbContext context;
        private readonly HttpClient _client;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;
        private readonly Exception? ex;

        public CustomerRepository(CustomerCrudDbContext Context, HttpClient client , ILogger<CustomerRepository> logger)
        {
            context = Context;
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _retryPolicy = CreateRetryPolicy(logger);
        }
        public async Task<HttpResponseMessage> GetDataAsync()
        {
            return await _retryPolicy.ExecuteAsync(() => _client.GetAsync("/api/Product/GetAllProducts"));
        }

        private AsyncRetryPolicy<HttpResponseMessage> CreateRetryPolicy(ILogger<CustomerRepository> logger)
        {
            return Policy.Handle<HttpRequestException>()
                         .OrResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                         .WaitAndRetryAsync(10, retryAttempt => TimeSpan.FromSeconds(Math.Pow(1, retryAttempt)), 
                             (exception, timespan, retryCount, context) =>
                             {
                                 logger.LogError(exception: ex, $"Request failed. Retry attempt {retryCount} in {timespan.TotalSeconds} seconds.");
                             });
        }
        public List<CustomerModel> Get()
        {
            return context.Customers.ToList<CustomerModel>();
        }
        public CustomerModel GetById(int id)
        {
            var customer = context.Customers.Find(id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }
        public string Post(CustomerModel customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer Record Created Successfully";
        }
        public string Put(CustomerModel customer)
        {
            var Cust = context.Customers.Find(customer);
            if (Cust == null)
            {
                return "Customer not found";
            }
            else
            {
                context.Customers.Update(customer);
                context.SaveChanges();
                return "Customer record updates succesfully";
            }
        }
        public string Delete(int id)
        {
            var customerToDelete = context.Customers.Find(id);
            if (customerToDelete != null)
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                return "Customer record deleted successfully";
            }
            else
            {
                return "Customer not found";
            }
        }
        public async Task<string> CallOtherApiMethod(string accessToken)
        {
            try
            {
                var retryPolicy = Policy.Handle<Exception>()
                                 .WaitAndRetryAsync(3, attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt)),
                                     (ex, timeSpan, attempt, context) =>
                                     {
                                         // Log or handle the retry here
                                         Console.WriteLine($"Retry attempt {attempt}, Exception: {ex.Message}");
                                     });

                // Execute the operation with retry policy
                return await retryPolicy.ExecuteAsync(async () =>
                {
                    // Create a new HttpRequestMessage
                    var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5097/api/Product/GetAllProducts");

                    // Add authorization header with bearer token
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    // Send the request
                    var response = await _client.SendAsync(request);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Throw an exception to trigger retry if the response is not successful
                        throw new HttpRequestException($"Error: {response.StatusCode}");
                    }
                });
            }
            catch (Exception ex)
            {
                 return $"An error occurred: {ex.Message}";
            }
        }

        public async Task<string> GetProductUsingId(int id)
        {
            try
            {

                var response = await _client.GetAsync("http://localhost:5097/api/Product/GetProductById?id=" + id);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
        public async Task<string> CreateProducts(ProductModel productModel)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(productModel);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync("http://localhost:5097/api/Product/CreateProduct", content);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
        public async Task<string> UpdateProducts(ProductModel productModel)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(productModel);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await _client.PutAsync("http://localhost:5097/api/Product/UpdateProduct", content);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
        public async Task<string> DeleteProducts(int id)
        {
            try
            {

                var response = await _client.DeleteAsync("http://localhost:5097/api/Product/DeleteProduct?id=" + id);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                else
                {
                    return $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
