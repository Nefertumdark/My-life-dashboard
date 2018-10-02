using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Plugin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Section> Sections { get; set; }
    }
}
