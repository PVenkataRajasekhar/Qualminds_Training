using Microsoft.EntityFrameworkCore;
using DTOExample.Model;
namespace DTOExample.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        { }
        public DbSet<Student> Students { get; set; }
    }
}
