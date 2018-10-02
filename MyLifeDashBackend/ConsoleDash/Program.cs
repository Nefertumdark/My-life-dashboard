using DataLayer;
using DataLayer.Entities;

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
                db.Plugins.Add(new Plugin { Name = "TestX" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var plugin in db.Plugins)
                {
                    Console.WriteLine(" - {0}", plugin.Name);
                }
            }
        }
    }
}
