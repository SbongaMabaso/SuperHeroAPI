using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //
        }

        //Code First Migration to db
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
