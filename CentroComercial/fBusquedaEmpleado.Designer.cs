namespace CentroComercial
{
    partial class fBusquedaEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBusquedaEmpleado));
            this.lTitulo = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.tBBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(110, 34);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(218, 31);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "Busca Empleado";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDNI.Location = new System.Drawing.Point(91, 107);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(37, 20);
            this.lDNI.TabIndex = 1;
            this.lDNI.Text = "DNI";
            // 
            // tBBuscarEmpleado
            // 
            this.tBBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBBuscarEmpleado.Location = new System.Drawing.Point(155, 104);
            this.tBBuscarEmpleado.Name = "tBBuscarEmpleado";
            this.tBBuscarEmpleado.Size = new System.Drawing.Size(135, 26);
            this.tBBuscarEmpleado.TabIndex = 2;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(164, 221);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(96, 30);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // fBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 322);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tBBuscarEmpleado);
            this.Controls.Add(this.lDNI);
            this.Controls.Add(this.lTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBusquedaEmpleado";
            this.Text = "Buscar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.TextBox tBBuscarEmpleado;
        private System.Windows.Forms.Button bBuscar;
    }
}