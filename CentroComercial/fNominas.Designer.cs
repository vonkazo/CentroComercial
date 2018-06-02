namespace CentroComercial
{
    partial class fNominas
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
            this.lNominas = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNominas
            // 
            this.lNominas.AutoSize = true;
            this.lNominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNominas.Location = new System.Drawing.Point(147, 9);
            this.lNominas.Name = "lNominas";
            this.lNominas.Size = new System.Drawing.Size(336, 39);
            this.lNominas.TabIndex = 0;
            this.lNominas.Text = "Nóminas ultimo año";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 352);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(272, 449);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(94, 33);
            this.bBuscar.TabIndex = 2;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // fNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 507);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lNominas);
            this.Name = "fNominas";
            this.Text = "Nominas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNominas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bBuscar;
    }
}