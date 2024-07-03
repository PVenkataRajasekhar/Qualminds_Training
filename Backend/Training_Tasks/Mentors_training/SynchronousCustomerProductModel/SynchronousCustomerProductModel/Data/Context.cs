using Microsoft.EntityFrameworkCore;
using SynchronousCustomerProductModel.Models;
using System.Collections.Generic;

namespace SynchronousCustomerProductModel.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        { }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
    }
}
