using Microsoft.EntityFrameworkCore;

namespace HeroesApp.Data.Models
{
    public class HeroesDataContext : DbContext
    {
        public HeroesDataContext()
        {
        }

        public HeroesDataContext(DbContextOptions<HeroesDataContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
