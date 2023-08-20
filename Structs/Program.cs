using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Juego
    {
        public string nombre;
        public string desarrollador;

        public void Mostrar()
        {
            Console.WriteLine("El nombre del juego es {0}", nombre);
            Console.WriteLine("El desarrollador es {0}", desarrollador);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego1;

            juego1.nombre = "Casa Zombie";
            juego1.desarrollador = "Nintendo";

            juego1.Mostrar();

            Console.Read();
        }
    }
}
