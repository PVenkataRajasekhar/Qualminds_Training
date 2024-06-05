using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FiltersDemo.Context
{
   
        public class FiltersDbContext : DbContext
        {
            public FiltersDbContext(DbContextOptions<FiltersDbContext> options) : base(options)
            {
            }

            // DbSet for each entity
            public DbSet<CustomerModel> Customers { get; set; }
        }
}
