namespace CentroComercial
{
    partial class fVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVentas));
            this.lVMuestraVentas = new System.Windows.Forms.ListView();
            this.lVentasTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lVMuestraVentas
            // 
            this.lVMuestraVentas.Location = new System.Drawing.Point(12, 116);
            this.lVMuestraVentas.Name = "lVMuestraVentas";
            this.lVMuestraVentas.Size = new System.Drawing.Size(729, 335);
            this.lVMuestraVentas.TabIndex = 0;
            this.lVMuestraVentas.UseCompatibleStateImageBehavior = false;
            // 
            // lVentasTitulo
            // 
            this.lVentasTitulo.AutoSize = true;
            this.lVentasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVentasTitulo.Location = new System.Drawing.Point(186, 33);
            this.lVentasTitulo.Name = "lVentasTitulo";
            this.lVentasTitulo.Size = new System.Drawing.Size(359, 39);
            this.lVentasTitulo.TabIndex = 1;
            this.lVentasTitulo.Text = "Lista de ventas anual";
            // 
            // fVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 463);
            this.Controls.Add(this.lVentasTitulo);
            this.Controls.Add(this.lVMuestraVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fVentas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lVMuestraVentas;
        private System.Windows.Forms.Label lVentasTitulo;
    }
}