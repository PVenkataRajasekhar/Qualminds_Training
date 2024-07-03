using Microsoft.EntityFrameworkCore;
using Product.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Context
{
    public class ProductCrudDbContext: DbContext
    {
        public ProductCrudDbContext(DbContextOptions<ProductCrudDbContext> options) : base(options)
        {
        }

        // DbSet for each entity
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToTable("Products");
        }
    }
}
