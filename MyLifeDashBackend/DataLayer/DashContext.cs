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
                new CatInstrument() { CatInstrumentId = 1, Name = "Savings" },
                new CatInstrument() { CatInstrumentId = 2, Name = "Equity MX" },
                new CatInstrument() { CatInstrumentId = 3, Name = "Debt MX" },
                new CatInstrument() { CatInstrumentId = 4, Name = "Others MX" },
                new CatInstrument() { CatInstrumentId = 5, Name = "Equity Tech USA" },
                new CatInstrument() { CatInstrumentId = 6, Name = "Equity USA" },
                new CatInstrument() { CatInstrumentId = 7, Name = "Debt USA" } );
        }
    }
}
