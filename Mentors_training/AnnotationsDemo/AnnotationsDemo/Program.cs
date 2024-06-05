
using Customer.core.ICustomerRepository;
using Customer.core.Service;
using Customer.Infrastructure.Context;
using Customer.Infrastructure.Repository;
using Customer.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

namespace AnnotationsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CustomerCrudDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("dbcn"),b=>b.MigrationsAssembly("AnnotationsDemo")));
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
