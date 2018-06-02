namespace CentroComercial
{
    partial class fBuscarEmpleado
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.lTitulo = new System.Windows.Forms.Label();
            this.tBCIF = new System.Windows.Forms.TextBox();
            this.lCIF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(163, 266);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(89, 33);
            this.bBuscar.TabIndex = 7;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(59, 44);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(314, 39);
            this.lTitulo.TabIndex = 6;
            this.lTitulo.Text = "Busca Proveedores";
            // 
            // tBCIF
            // 
            this.tBCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCIF.Location = new System.Drawing.Point(163, 178);
            this.tBCIF.Name = "tBCIF";
            this.tBCIF.Size = new System.Drawing.Size(137, 23);
            this.tBCIF.TabIndex = 5;
            // 
            // lCIF
            // 
            this.lCIF.AutoSize = true;
            this.lCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCIF.Location = new System.Drawing.Point(63, 181);
            this.lCIF.Name = "lCIF";
            this.lCIF.Size = new System.Drawing.Size(94, 17);
            this.lCIF.TabIndex = 4;
            this.lCIF.Text = "Cif Proveedor";
            // 
            // fBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 392);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.tBCIF);
            this.Controls.Add(this.lCIF);
            this.Name = "fBuscarEmpleado";
            this.Text = "Buscar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.TextBox tBCIF;
        private System.Windows.Forms.Label lCIF;
    }
}