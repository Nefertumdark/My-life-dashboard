using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDash
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DashContext())
            {            
                Console.WriteLine("All plugins in database:");
                var data = db.Plugins.Include(pl => pl.Sections);
                foreach (var plugin in data)
                {
                    Console.WriteLine($"{plugin.Name} - Num Secciones {plugin.Sections.Count}");
                }
            }
        }
    }
}
