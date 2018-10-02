using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities
{
    public class Configuration
    {
        [Key]
        [ForeignKey("Section")]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Taxes { get; set; }
        public List<HistoricalEntry> HistoricalEntries { get; set; }
        public List<ConfigurationInstrument> ConfigurationInstruments { get; set; }
        public Section Section { get; set; }
    }
}