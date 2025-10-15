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
    public partial class FrmMatriz3x3 : Form
    {
        int[,] vector = new int[3, 3];
        int fila = 0, columna = 0;

        public FrmMatriz3x3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(tbDato.Text);

            vector[fila, columna] = valor;
            columna++;

            tbDato.Clear();

            if (columna == 3)
            {
                columna = 0;
                fila++;
            }

            if (fila == 3)
            {
                MessageBox.Show("Matriz llena...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAgregar.Enabled = false;
            }

            lblMatriz.Text = Mostrar();
            tbDato.Focus();
        }

        private String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Matriz 3x3x3");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append($"{vector[i, j], 4}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
