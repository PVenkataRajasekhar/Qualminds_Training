using Microsoft.EntityFrameworkCore;
using ASynchronousModelWebAPI.Models;

namespace ASynchronousModelWebAPI.Data
{
        public class Context : DbContext
        {
            public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
            { }

            public DbSet<Student> Students { get; set; }
        }
}
