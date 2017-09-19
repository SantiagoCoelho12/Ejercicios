using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectorioPerros;

namespace UIDirectorioPerros
{
    public partial class AgregarDuenio : UserControl
    {
        private Directorio miDir;

        public AgregarDuenio(Directorio dir)
        {
            InitializeComponent();
            miDir = dir;
        }

        private void buttonAgregarDuenio_Click(object sender, EventArgs e)
        {
            if (AlgunVacio())
            {
                MessageBox.Show("No puede haber vacios");
            }
            else
            {
                AgregarNuevoDuenio();
                VaciarCampos();
            }
        }

        private bool AlgunVacio()
        {
            return textCelular.Text.Trim() == "" || textNombre.Text.Trim() == "";
        }

        private void AgregarNuevoDuenio()
        {
            string nom = textNombre.Text;
            string cel = textCelular.Text;
            Duenio duenioNuevo = new Duenio() { Nombre = nom, Telefono = cel };
            miDir.AgregarDuenio(duenioNuevo);
            MessageBox.Show("Dueño Agregado con exito");
        }
        private void VaciarCampos()
        {
            textCelular.Text = "";
            textNombre.Text = "";
        }
    }
}
