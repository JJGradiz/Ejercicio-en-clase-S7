namespace Corte2.Formularios
{
    partial class FrmString
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.tbFrase = new System.Windows.Forms.TextBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(13, 13);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(89, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Ingresa una frase";
            // 
            // tbFrase
            // 
            this.tbFrase.Location = new System.Drawing.Point(109, 13);
            this.tbFrase.Name = "tbFrase";
            this.tbFrase.Size = new System.Drawing.Size(436, 20);
            this.tbFrase.TabIndex = 1;
            this.tbFrase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(509, 51);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(34, 13);
            this.lblMaximo.TabIndex = 2;
            this.lblMaximo.Text = "0 - 60";
            // 
            // FrmString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.tbFrase);
            this.Controls.Add(this.lblFrase);
            this.Name = "FrmString";
            this.Text = "FrmString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox tbFrase;
        private System.Windows.Forms.Label lblMaximo;
    }
}