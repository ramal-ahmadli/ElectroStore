using Microsoft.EntityFrameworkCore;

namespace ElectroStore.Models.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Technology> Technologies { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
            
        }

        protected AppDbContext()
        {
        }
    }
}
