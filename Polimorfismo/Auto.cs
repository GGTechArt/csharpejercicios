using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        //Constructor parametretizado
        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        } 
        //Metodos
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0] - Color {1}", HP, Color);
        }

        public void Reparar()
        {
            Console.WriteLine("El auto ya esta reparado");
        }
    }
}
