using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class ConfigurationInstrument : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public float Percentaje { get; set; }
        public CatInstrument CatInstruments { get; set; }
        public Configuration Configuration { get; set; }
    }
}