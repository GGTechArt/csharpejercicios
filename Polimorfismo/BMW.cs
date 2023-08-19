using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class BMW:Auto
    {
        //Variables
        private string marca = "BMW";

        public string Modelo { get; set; }

        public BMW (int hp, string color, string modelo):base(hp, color)
        {
            this.Modelo = modelo;
        }

        //Metodos
        public void MostrarDetalles()
        {
            Console.WriteLine("Marca {0} -  Modelo: {1} HP: {2] - Color {3}", marca, Modelo, HP, Color);
        }
        public void Reparar()
        {
            Console.WriteLine("El BMW {0} esta reparado",Modelo);
        }
    }
}
