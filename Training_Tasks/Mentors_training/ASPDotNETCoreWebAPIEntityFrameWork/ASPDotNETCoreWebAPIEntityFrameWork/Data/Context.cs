using ASPDotNETCoreWebAPIEntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNETCoreWebAPIEntityFrameWork.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProducts> CustomerProducts { get; set; }
    }
}
