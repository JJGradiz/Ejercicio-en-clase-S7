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
    public partial class FrmMatriz4x4 : Form
    {
        int[,] matriz = new int[4, 4];
        int fila = 0, columna = 0;

        public FrmMatriz4x4()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(tbDato.Text);

            matriz[fila, columna] = valor;

            columna++;
            tbDato.Clear();

            if (columna == 4)
            {
                columna = 0;
                fila++;
            }

            if (fila == 4)
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
            sb.AppendLine("Matriz 4x4");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sb.Append($"{matriz[i, j],4}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
