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
    public partial class fBusquedaEmpleado : Form
    {
        public fInformacionPersonal ventana;
        public fBusquedaEmpleado()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            ventana = new fInformacionPersonal();
            ventana.Show();
        }
    }
}
