namespace CentroComercial
{
    partial class fNominaPropia
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
            this.lNominaPropia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lMes = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNominaPropia
            // 
            this.lNominaPropia.AutoSize = true;
            this.lNominaPropia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNominaPropia.Location = new System.Drawing.Point(91, 18);
            this.lNominaPropia.Name = "lNominaPropia";
            this.lNominaPropia.Size = new System.Drawing.Size(194, 31);
            this.lNominaPropia.TabIndex = 0;
            this.lNominaPropia.Text = "Buscar nomina";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lMes
            // 
            this.lMes.AutoSize = true;
            this.lMes.Location = new System.Drawing.Point(30, 124);
            this.lMes.Name = "lMes";
            this.lMes.Size = new System.Drawing.Size(66, 13);
            this.lMes.TabIndex = 2;
            this.lMes.Text = "Mes/nomina";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(134, 206);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(92, 32);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = " Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // fNominaPropia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 314);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.lMes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lNominaPropia);
            this.Name = "fNominaPropia";
            this.Text = "Buscar Nomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNominaPropia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lMes;
        private System.Windows.Forms.Button bAceptar;
    }
}