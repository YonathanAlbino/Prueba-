using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        //Atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        //Constructor
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        
        //Propiedad
        public string Modelo
        {
            get { return modelo; }
        }
        
        public string Marca
        {
            get { return marca; }   
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set { codigoOperador = value;
                verificacion(ref codigoOperador);
            }
        }

        //metodo o funcion
        //Primer cambio gitHub
        public int verificacion(ref int n)
        {
            if (n == 1 || n == 2 || n == 3)
                return n;
            else
                return 0;
        }

        //metodo llarmar
        public string llamar()
        {
            return "Realizando llamada...";
        }
        //sobre carga metodo llamar
        
        public string llamar(string contancto)
        {
            return "llamando a: " + contancto;
        }
    
    }


}
