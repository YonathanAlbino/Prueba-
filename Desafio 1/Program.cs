using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("j7", "samsung");
            t1.CodigoOperador = 15;
            Console.WriteLine(t1.CodigoOperador);
            Console.ReadKey();

            //Telefono t2 = new Telefono("j7", "samsung");
            //Console.WriteLine(t2.llamar());
            //Console.WriteLine(t2.llamar("Pepillo"));
            //Console.WriteLine(t2.Marca);
            //Console.ReadKey();

            Perro p1 = new Perro("Cualsito", "Blanco");
            p1.Dueño = "jose";
            //Console.WriteLine(p1.Dueño);

            //p1.Edad = 12;
            //Console.WriteLine(p1.Edad);

            //Console.WriteLine(p1.Nombre);

            //Console.WriteLine(p1.Color);

            Perro p2 = new Perro("Gutierrez", "Marron");
            Console.WriteLine(p2.Nombre);

            Console.WriteLine(p2.Color);

            p2.Edad = 5;
            Console.WriteLine(p2.Edad);

            p2.Dueño = "yoni";
            Console.WriteLine(p2.Dueño);

            Console.WriteLine(p2.LLamarAlPerro());
            Console.WriteLine(p2.LLamarAlPerro("Cualsito"));
            


            Console.ReadKey();
        }
    }
}
