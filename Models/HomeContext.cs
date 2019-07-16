using Microsoft.EntityFrameworkCore;

namespace CruDelicious.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options) { }
        public DbSet<Dishes> Dishes {get;set;}
    }
}