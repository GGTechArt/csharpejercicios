using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 13; int b = 9;

            Console.WriteLine("El redondedo hacia arriba de 15.3 es {0}", Math.Ceiling(15.3));
            Console.WriteLine("El redondedo hacia abajo de 15.3 es {0}", Math.Floor(15.3));
            Console.WriteLine("El valor mas bajo entre {0} y {1} es {2} ",a,b, Math.Min(a,b));
            Console.WriteLine("El valor mas alto entre {0} y {1} es {2} ", a, b, Math.Max(a, b));

            Console.WriteLine("3 elevado a a la 5 es " + Math.Pow(3, 5));
            Console.WriteLine("PI es {0}", Math.PI);

            Console.WriteLine("La raiz cuadrada de 25 es {0}",Math.Sqrt(25));
            Console.WriteLine("El absoluto de -25 es {0}", Math.Abs(25));

            Console.WriteLine("El coseno es 1 {0}", Math.Cos(1));

            Console.Read();
        }
    }
}
