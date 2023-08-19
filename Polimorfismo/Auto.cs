using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Polimorfismo
{
    class Auto
    {
        //Propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        //Tiene una relación con Auto info
        protected AutoInfo autoInfo = new AutoInfo();

        //Constructor parametretizado
        public Auto(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        } 
        //Metodos
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0} - Color {1}", HP, Color);
        }

        public virtual void  Reparar()
        {
            Console.WriteLine("El auto ya esta reparado");
        }

        public void SetearAutoInfo(int id, string propietario)
        {
            autoInfo.Id = id;
            autoInfo.Propietario = propietario;
        }

        public void LeerAutoInfo()
        {
            Console.WriteLine("El ID del auto es {0} y su propietario es {1}",autoInfo.Id, autoInfo.Propietario);
        }
    }
}
