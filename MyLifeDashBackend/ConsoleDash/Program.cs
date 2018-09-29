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
            var repo = new DashRepo<Plugin>();
            repo.Add(new Plugin() { Name = "Test" });
        }
    }
}
