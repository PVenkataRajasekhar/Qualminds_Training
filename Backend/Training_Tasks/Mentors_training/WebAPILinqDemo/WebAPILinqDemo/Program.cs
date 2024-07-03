
using Microsoft.EntityFrameworkCore;
using Linq.Infrastructure.Data;
using Linq.Infrastructure.Repository;
using Linq.Infrastructure.Service;
using Linq.core.Repository;
using Linq.core.Service;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;


namespace WebAPILinqDemo
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
            builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("dbcn"), b => b.MigrationsAssembly("WebAPILinqDemo")));
            builder.Services.AddScoped<IEmployeeDepartmentRepository, EmployeeDepartmentRepository>();
            builder.Services.AddTransient<IEmployeeDepartmentService, EmployeeDepartmentService>();


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
