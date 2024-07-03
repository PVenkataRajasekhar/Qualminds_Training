using Microsoft.EntityFrameworkCore;
using WebApplication_Security.Model;

namespace WebApplication_Security.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions)
        { }
        public DbSet<UserModel> Users { get; set; }
    }
}
