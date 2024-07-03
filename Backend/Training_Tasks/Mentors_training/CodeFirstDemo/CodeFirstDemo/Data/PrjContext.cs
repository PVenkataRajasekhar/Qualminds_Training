using CodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace CodeFirstDemo.Data
{
    public class PrjContext : DbContext

    {

        public PrjContext(DbContextOptions<PrjContext> contextOptions) : base(contextOptions)

        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
