using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DirectorioPerros;

namespace UIDirectorioPerros
{
    public partial class UIprincipal : Form
    {
        public Directorio DirectorioPrincipal { get; set; }
        public UIprincipal()
        {
            InitializeComponent();
            DirectorioPrincipal = new Directorio();
            CargarPanelPrincipal();
        }

    
        private void CargarPanelPrincipal()
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarDuenio = new AgregarDuenio(DirectorioPrincipal);
            panelPrincipal.Controls.Add(agregarDuenio);
        }

        private void btnAgregarDuenio_Click(object sender, EventArgs e)
        {
            CargarPanelPrincipal();
        }

        private void btnAgregarPerro_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
           // UserControl agregarPerro = new AgregarPerro(DirectorioPrincipal);
            //panelPrincipal.Controls.Add(agregarPerro);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
           // UserControl verPerros = new VerPerros(DirectorioPrincipal);
            //panelPrincipal.Controls.Add(verPerros);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
