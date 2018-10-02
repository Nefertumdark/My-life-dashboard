using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class CatInstrument
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ConfigurationInstrument> ConfigurationInstrument { get; set; }
    }
}