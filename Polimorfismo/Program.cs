using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autos = new List<Auto>
            {
                new Audi(200,"azul","A4"),
                new BMW(200,"azul","A4"),

            };
        }
    }
}
