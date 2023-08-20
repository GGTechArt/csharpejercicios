using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRamdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RuedaFortuna = new Random();

            int numRespuesta;

            Console.WriteLine("Por favor, ingresa una  pregunta que se responda con si o con no")

            numRespuesta = RuedaFortuna.Next(1, 4);

            if(numRespuesta == 1 ) 
            {
                Console.WriteLine("Sí");
            }else if(numRespuesta == 2 )
            {
                Console.WriteLine("Quizás");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            /*Random dado = new Random();
            int numCara;

            for (int i = 0; i < 10; i++) 
            {
                numCara = dado.Next(1,7);
                Console.WriteLine(numCara);
            }

            Console.Read();*/
        }
    }
}
