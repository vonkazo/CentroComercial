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
    public partial class fBuscarProveedor : Form
    {
        public fDatosProveedores ventana;
        public fBuscarProveedor()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            ventana = new fDatosProveedores();
            ventana.Show();
        }
    }
}
