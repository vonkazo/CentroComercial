﻿using System;
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
    }
}
