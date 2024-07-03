

using Customer.Core.Repository;
using Customer.Core.Service;
using Customer.Infrastructure.Context;
using Customer.Infrastructure.Repository;
using Customer.Infrastructure.Service;
using CustomerCRUDinAPI.Polly;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using Customer.Infrastructure.Repository;




namespace CustomerCRUDinAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CustomerCrudDbContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("dbcn")));
            // Register HttpClient service for making HTTP requests.
            builder.Services.AddHttpClient();

            // Configure HttpClient with BaseUrl from MyApiSettings
            builder.Services.AddHttpClient("ProductCRUDinAPI", httpClient =>
            {
                httpClient.BaseAddress = new Uri(builder.Configuration["MyApiSettings:BaseUrl"]);
            });

            // Configure Polly retry policy
            
            builder.Services.AddHttpClient();

            // Configure HttpClient with BaseUrl from MyApiSettings
            builder.Services.AddHttpClient("ProductCRUDinAPI", httpClient =>
            {
                httpClient.BaseAddress = new Uri(builder.Configuration["MyApiSettings:BaseUrl"]);
            })
            .AddPolicyHandler(GetRetryPolicy());

            // Register repositories and services with dependency injection.
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();

            var app = builder.Build();

            // Enable Swagger/OpenAPI documentation only in the development environment.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();

        }

        static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                .WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }

    }
}

