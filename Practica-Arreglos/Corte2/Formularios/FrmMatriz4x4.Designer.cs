namespace Corte2.Formularios
{
    partial class FrmMatriz4x4
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
            this.lblDato = new System.Windows.Forms.Label();
            this.tbDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDato.Location = new System.Drawing.Point(13, 13);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(48, 20);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "Dato:";
            // 
            // tbDato
            // 
            this.tbDato.Location = new System.Drawing.Point(17, 37);
            this.tbDato.Name = "tbDato";
            this.tbDato.Size = new System.Drawing.Size(133, 20);
            this.tbDato.TabIndex = 1;
            this.tbDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(157, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz.Location = new System.Drawing.Point(13, 74);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(219, 124);
            this.lblMatriz.TabIndex = 3;
            this.lblMatriz.Text = "Matriz";
            // 
            // FrmMatriz4x4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbDato);
            this.Controls.Add(this.lblDato);
            this.Name = "FrmMatriz4x4";
            this.Text = "FrmMatriz4x4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.TextBox tbDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMatriz;
    }
}