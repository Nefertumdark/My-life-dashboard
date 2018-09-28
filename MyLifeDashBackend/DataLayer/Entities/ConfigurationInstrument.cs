using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class ConfigurationInstrument : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public float Percentaje { get; set; }
        public virtual List<CatInstrument> CatInstruments { get; set; }
    }
}