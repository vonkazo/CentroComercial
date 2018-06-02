using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroComercial
{
    public partial class fMenuPrincipal : Form
    {
        public fInformacionPersonal ventana3;
        public fVentas ventana4;
        public fNominas ventana5;
        public fNominaPropia ventana6;
        public fArticulos ventana7;
        public fBuscarProveedor ventana8;
        public fBusquedaEmpleado ventana9;
        public fMenuPrincipal()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            fLogin.ventana1.Visible = true;
            this.Close();
        }

        private void bInformacionPersonal_Click(object sender, EventArgs e)
        {
            ventana3 = new fInformacionPersonal();
            ventana3.Show();
        }

        private void bVentas_Click(object sender, EventArgs e)
        {
            ventana4 = new fVentas();
            ventana4.Show();
        }

        private void bNominasEmple_Click(object sender, EventArgs e)
        {
            ventana5 = new fNominas();
            ventana5.Show();
        }

        private void bNominas_Click(object sender, EventArgs e)
        {
            ventana6 = new fNominaPropia();
            ventana6.Show();
        }

        private void bArticulos_Click(object sender, EventArgs e)
        {
            ventana7 = new fArticulos();
            ventana7.Show();
        }

        private void bInfoProveedores_Click(object sender, EventArgs e)
        {
            ventana8 = new fBuscarProveedor();
            ventana8.Show();
        }

        private void bInfoEmpleados_Click(object sender, EventArgs e)
        {
            ventana9 = new fBusquedaEmpleado();
            ventana9.Show();
        }
    }
}
