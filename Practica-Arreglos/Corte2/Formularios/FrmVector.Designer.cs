namespace Corte2.Formularios
{
    partial class FrmVector
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEscrNota = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblNotas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leer 10 notas y obtener los 3 primeros lugares";
            // 
            // lblEscrNota
            // 
            this.lblEscrNota.AutoSize = true;
            this.lblEscrNota.Location = new System.Drawing.Point(16, 86);
            this.lblEscrNota.Name = "lblEscrNota";
            this.lblEscrNota.Size = new System.Drawing.Size(87, 13);
            this.lblEscrNota.TabIndex = 1;
            this.lblEscrNota.Text = "Escribe una nota";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(109, 83);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(142, 20);
            this.tbNota.TabIndex = 2;
            this.tbNota.TextChanged += new System.EventHandler(this.tbNota_TextChanged);
            this.tbNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNota_KeyDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 135);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(19, 188);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(0, 13);
            this.lblNotas.TabIndex = 4;
            // 
            // FrmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.lblEscrNota);
            this.Controls.Add(this.label1);
            this.Name = "FrmVector";
            this.Text = "Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEscrNota;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblNotas;
    }
}