﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace CentroComercial
{
    public partial class fLogin : Form
    {
        public static fLogin ventana1;
        public static fMenuPrincipal ventana2;
        //public static fNominas;
        public fLogin()
        {
            InitializeComponent();
            ventana1 = this;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            int pasa = 1;
            if(pasa != null)
            {
                ventana2 = new fMenuPrincipal();
                ventana2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no validos");
            }

            
        }
    }
}
