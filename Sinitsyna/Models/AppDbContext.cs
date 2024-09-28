using Microsoft.EntityFrameworkCore;

namespace Sinitsyna.Models
{
    public class AppDbContext: DbContext
    {
        DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            Database.EnsureCreated();
            
        }

    }
}
