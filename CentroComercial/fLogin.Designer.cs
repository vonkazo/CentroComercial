namespace CentroComercial
{
    partial class fLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBUsuario = new System.Windows.Forms.Label();
            this.lBContraseña = new System.Windows.Forms.Label();
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBUsuario
            // 
            this.lBUsuario.AutoSize = true;
            this.lBUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBUsuario.Location = new System.Drawing.Point(62, 102);
            this.lBUsuario.Name = "lBUsuario";
            this.lBUsuario.Size = new System.Drawing.Size(108, 31);
            this.lBUsuario.TabIndex = 0;
            this.lBUsuario.Text = "Usuario";
            this.lBUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBContraseña
            // 
            this.lBContraseña.AutoSize = true;
            this.lBContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBContraseña.Location = new System.Drawing.Point(15, 195);
            this.lBContraseña.Name = "lBContraseña";
            this.lBContraseña.Size = new System.Drawing.Size(155, 31);
            this.lBContraseña.TabIndex = 2;
            this.lBContraseña.Text = "Contraseña";
            this.lBContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBUsuario
            // 
            this.tBUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUsuario.Location = new System.Drawing.Point(176, 105);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(149, 30);
            this.tBUsuario.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(176, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 30);
            this.textBox2.TabIndex = 4;
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bLogin.Location = new System.Drawing.Point(200, 295);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(102, 35);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 404);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tBUsuario);
            this.Controls.Add(this.lBContraseña);
            this.Controls.Add(this.lBUsuario);
            this.Name = "fLogin";
            this.Text = "Login CComercial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBUsuario;
        private System.Windows.Forms.Label lBContraseña;
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bLogin;
    }
}

