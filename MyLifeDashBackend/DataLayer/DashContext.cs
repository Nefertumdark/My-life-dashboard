using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DashContext : DbContext
    {
        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Configuration> Configuration { get; set; }
        public DbSet<HistoricalEntry> HistoricalEntries { get; set; }
        public DbSet<ConfigurationInstrument> ConfigurationInstruments { get; set; }
        public DbSet<CatInstrument> CatInstruments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DashSQL.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatInstrument>().HasData( 
                new CatInstrument() { Id = 1, Name = "Savings" },
                new CatInstrument() { Id = 2, Name = "Equity MX" },
                new CatInstrument() { Id = 3, Name = "Debt MX" },
                new CatInstrument() { Id = 4, Name = "Others MX" },
                new CatInstrument() { Id = 5, Name = "Equity Tech USA" },
                new CatInstrument() { Id = 6, Name = "Equity USA" },
                new CatInstrument() { Id = 7, Name = "Debt USA" } );
        }
    }
}
