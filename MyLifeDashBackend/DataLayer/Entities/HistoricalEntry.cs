using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class HistoricalEntry
    {
        [Key]
        public int HistoricalEntryId { get; set; }
        public float Total { get; set; }
        public float Gain { get; set; }
        public DateTime Date { get; set; }
        public Section Section { get; set; }
        public Configuration Configuration { get; set; }
    }
}