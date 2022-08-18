using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Perro
    {
        //Atributos
        private string nombre;
        private string color;
        private int edad;
        private string dueño;

        //Constructor
        public Perro(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        //propiedades
        public string Nombre
        {
            get { return nombre; }
        }

        public string Color
        {
            get { return color; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Dueño
        {
            get { return dueño; }
            set { dueño = value;
                dueño = SoloNosotros(dueño);
            }
        }

        //Metodo
        public string LLamarAlPerro()
        {
            return "llamando al perro";
        }

        public string LLamarAlPerro(string nombre)
        {
            return "Llamando a: " + nombre;
        }

        public string SoloNosotros(string n1)
        {
            if (n1 == "yoni" || n1 == "dayra")
                return n1;
            else
                return n1 + " No es el dueño del perro";
            
        }
    }
}
