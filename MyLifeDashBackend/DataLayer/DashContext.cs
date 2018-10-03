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
    }
}
