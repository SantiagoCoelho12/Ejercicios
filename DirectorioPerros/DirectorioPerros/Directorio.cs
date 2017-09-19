using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioPerros
{
    public class Directorio
    {
        public List<Duenio> Duenios { get; set; }

        public Directorio()
        {
            Duenios = new List<Duenio>();
        }
        public void AgregarPerro(Duenio duenioPerro, Perro PerroAgregar)
        {
            if (ExisteDueño(duenioPerro))
            {
                Duenio DuenioReal = ObtenerDuenio(duenioPerro);
                DuenioReal.Perros.Add(PerroAgregar);
            }
        }
        public void AgregarDuenio(Duenio DuenioAgregar)
        {
            if (!ExisteDueño(DuenioAgregar))
            {
                Duenios.Add(DuenioAgregar);
            }

        }

        bool ExisteDueño(Duenio duenioPerro)
        {
            return Duenios.Any(unDuenio => unDuenio.Equals(duenioPerro));
        }

        Duenio ObtenerDuenio(Duenio DuenioPerro)
        {
            return Duenios.Find(unDuenio => unDuenio.Equals(DuenioPerro));
        }
    }
}
