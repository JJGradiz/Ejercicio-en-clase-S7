namespace Corte2
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
            this.Vector = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.lblMsn = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vector
            // 
            this.Vector.AutoSize = true;
            this.Vector.Location = new System.Drawing.Point(12, 9);
            this.Vector.Name = "Vector";
            this.Vector.Size = new System.Drawing.Size(223, 13);
            this.Vector.TabIndex = 0;
            this.Vector.Text = "Leer 10 notas y obtener los primeros 3 lugares";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la nota:";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(112, 47);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 20);
            this.tbNota.TabIndex = 2;
            // 
            // lblMsn
            // 
            this.lblMsn.Location = new System.Drawing.Point(12, 103);
            this.lblMsn.Name = "lblMsn";
            this.lblMsn.Size = new System.Drawing.Size(100, 23);
            this.lblMsn.TabIndex = 3;
            this.lblMsn.Text = "Primeros lugares";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(251, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 441);
            this.Controls.Add(this.lblMsn);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.Vector);
            this.Controls.Add(this.label1);
            this.Name = "FrmVector";
            this.Text = "FrmVector";
            this.Load += new System.EventHandler(this.FrmVector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Vector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label lblMsn;
        private System.Windows.Forms.Button btnAgregar;
    }
}