using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class M3:BMW
    {
        public M3(int hp, string color, string modelo) : base(hp, color,modelo)
        {
            this.Modelo = modelo;
        }

        public override void Reparar()
        {
            base.Reparar();
        }
    }
}
