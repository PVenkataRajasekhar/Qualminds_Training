using AttributeRouting.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AttributeRouting.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        { }

        public DbSet<Products> Products { get; set; }
    }
}
