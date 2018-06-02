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
    public partial class fNominaPropia : Form
    {
        public fDatosNomina ventana;
        public fNominaPropia()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            ventana = new fDatosNomina();
            ventana.Show();
        }


    }
}
