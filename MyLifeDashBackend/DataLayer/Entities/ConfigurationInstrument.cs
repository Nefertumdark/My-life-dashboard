using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class ConfigurationInstrument
    {
        [Key]
        public int ConfigurationInstrumentId { get; set; }
        public float Percentaje { get; set; }
        public CatInstrument CatInstruments { get; set; }
        public Configuration Configuration { get; set; }
    }
}