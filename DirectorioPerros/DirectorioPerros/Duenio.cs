using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioPerros
{
    public class Duenio
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public ICollection<Perro> Perros { get; set; }

        public Duenio()
        {
            Perros = new List<Perro>();
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + " Telefono: " + Telefono;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else 
            {
                return Nombre == ((Duenio)obj).Nombre && Telefono == ((Duenio)obj).Telefono; 
            }
        }
    }
}

