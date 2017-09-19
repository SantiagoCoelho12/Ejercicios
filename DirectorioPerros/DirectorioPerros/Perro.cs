using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioPerros
{
    public class Perro
    {
        public enum Tamanio { Chico, Mediano, Grande }
        public string Nombre { set; get; }
        public string Raza { get; set; }
        public Tamanio tamanio { get; set; }

        public Perro(string nombre, string raza, Tamanio tam)
        {
            Nombre = nombre;
            Raza = raza;
            tamanio = tam;
        }
        public override string ToString()
        {
            return "Nombre : " + Nombre + " Raza: " + Raza + "Tamaño: " + tamanio;
        }
    }
}
