using Microsoft.EntityFrameworkCore;
using Customer.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Infrastructure.Context
{
    public class CustomerCrudDbContext : DbContext
    {
        public CustomerCrudDbContext(DbContextOptions<CustomerCrudDbContext> options) : base(options)
        {
        }

        // DbSet for each entity
        public DbSet<CustomerModel> Customers { get; set; }

        // Configure entity mappings in OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map CustomerModel to customer table
            modelBuilder.Entity<CustomerModel>().ToTable("Customers");
        }
    }
}
