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
    public partial class FrmMatriz2x2 : Form
    {
        int[,] matriz = new int[2, 2];
        int fila = 0, columna = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(tbDato.Text);
            matriz[fila, columna] = valor;
            tbDato.Clear();

            columna++;

            if (columna == 2)
            {
                columna = 0;
                fila++;
            }
            if (fila == 2)
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
            sb.AppendLine("Matriz 2x2");

            for (int i = 0; i< 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sb.Append($"{matriz[i, j], 4}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public FrmMatriz2x2()
        {
            InitializeComponent();
        }
    }
}
