using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Dia { Lu, Ma, Mi, Ju, Vi, Sa, Do}

    enum Mes { Enero=1, Febrero, Marzo, Abril, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre}
    internal class Program
    {
        static void Main(string[] args)
        {
            Dia viernes = Dia.Vi;
            Dia domingo = Dia.Do;

            Dia a = Dia.Vi;

            Console.WriteLine(Dia.Lu);

            Console.WriteLine((int)Dia.Lu);  

            Console.WriteLine(viernes == a);

            Console.WriteLine((int) Mes.Enero);
            Console.Read();
        }
    }
}
