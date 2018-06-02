namespace CentroComercial
{
    partial class fArticulos
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lArticulos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(41, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(447, 256);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lArticulos
            // 
            this.lArticulos.AutoSize = true;
            this.lArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArticulos.Location = new System.Drawing.Point(187, 26);
            this.lArticulos.Name = "lArticulos";
            this.lArticulos.Size = new System.Drawing.Size(148, 39);
            this.lArticulos.TabIndex = 1;
            this.lArticulos.Text = "Articulos";
            // 
            // fArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 374);
            this.Controls.Add(this.lArticulos);
            this.Controls.Add(this.listView1);
            this.Name = "fArticulos";
            this.Text = "Lista Articulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lArticulos;
    }
}