using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte2.Formularios
{
    public partial class FrmString : Form
    {
        public FrmString()
        {
            InitializeComponent();
        }

        public String contar(int tamanho, string frase)
        {
            Evaluar(ref tbFrase);
            return "Faltan: " + (tamanho - frase.Length);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblMaximo.Text = contar(60, tbFrase.Text);
            if (tbFrase.Text.Length >= 60)
            {
                MessageBox.Show("Ha superado el maximo de caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbFrase.Enabled = false;
            }
        }

        private void Evaluar(ref TextBox tb)
        {
            string Texto = tb.Text;

            if (Texto.Length <= 30) tb.ForeColor = Color.Green;
            else if (Texto.Length >= 31 && Texto.Length <= 50) tb.ForeColor = Color.Orange;
            else tb.ForeColor = Color.Red;
        }
    }
}
