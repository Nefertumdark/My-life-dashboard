using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Section : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Total { get; set; }
        public float Gain { get; set; }
        public List<HistoricalEntry> Sections { get; set; }
        public Configuration Configuration { get; set; }
        public Plugin Plugin { get; set; }
    }
}