namespace CentroComercial
{
    partial class fBuscarProveedor
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
            this.lCIF = new System.Windows.Forms.Label();
            this.tBCIF = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCIF
            // 
            this.lCIF.AutoSize = true;
            this.lCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCIF.Location = new System.Drawing.Point(53, 114);
            this.lCIF.Name = "lCIF";
            this.lCIF.Size = new System.Drawing.Size(94, 17);
            this.lCIF.TabIndex = 0;
            this.lCIF.Text = "Cif Proveedor";
            // 
            // tBCIF
            // 
            this.tBCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCIF.Location = new System.Drawing.Point(153, 111);
            this.tBCIF.Name = "tBCIF";
            this.tBCIF.Size = new System.Drawing.Size(137, 23);
            this.tBCIF.TabIndex = 1;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(60, 27);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(314, 39);
            this.lTitulo.TabIndex = 2;
            this.lTitulo.Text = "Busca Proveedores";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(153, 199);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(89, 33);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // fBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 330);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.tBCIF);
            this.Controls.Add(this.lCIF);
            this.Name = "fBuscarProveedor";
            this.Text = "Busca Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCIF;
        private System.Windows.Forms.TextBox tBCIF;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bBuscar;
    }
}