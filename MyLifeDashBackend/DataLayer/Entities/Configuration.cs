using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Configuration : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Taxes { get; set; }
        public virtual List<HistoricalEntry> HistoricalEntries { get; set; }
        public virtual List<ConfigurationInstrument> ConfigurationInstruments { get; set; }
    }
}