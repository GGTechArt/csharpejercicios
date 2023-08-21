using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime tiempo = new DateTime(1992, 01, 02);

            Console.WriteLine("El nacimiento fue el {0}",tiempo);

            //Mostrar fecha actual
            Console.WriteLine(DateTime.Today);

            //Hora actual
            Console.WriteLine(DateTime.Now);

            DateTime maniana = ProximoDia();
            Console.WriteLine("Mañana va a ser {0}", maniana);

            Console.WriteLine("Hoy es {0}", DateTime.Today.DayOfWeek);

            Console.WriteLine(PrimerDiaDelAnio(1999));

            int dias = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("El mes de febrero del 2000 tuvo {0} dias", dias);

            dias = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("El mes de febrero del 2001 tuvo {0} dias", dias);

            dias = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("El mes de febrero del 2004 tuvo {0} dias", dias);

            DateTime ahora = DateTime.Now;
            Console.WriteLine("Minuto: {0}", ahora.Minute);

            Console.WriteLine("En este momento es {0} Horas, {1} Minutos, {2} segundos. ", ahora.Hour, ahora.Minute, ahora.Second);

            Console.WriteLine("Por favor ingrese una fecha en el siguiente formato: aaaa-mm-dd");
            string ingreso = Console.ReadLine();

            if(DateTime.TryParse(ingreso, out tiempo) ) 
            {
                Console.WriteLine(tiempo);
                TimeSpan diasEnteros = ahora.Subtract(tiempo);
                Console.WriteLine("Dias que pasaton desde esa fecha {0}", diasEnteros.Days);
            }
            else
            { 
                Console.WriteLine("Ingreso Incorrecto");
            }

            Console.Read();
        }

        static DateTime ProximoDia()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime PrimerDiaDelAnio(int anio)
        {
            return new DateTime(anio,1,1);
        }
    }
}
