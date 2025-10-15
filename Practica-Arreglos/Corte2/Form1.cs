using Corte2.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmVector().ShowDialog();
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz2x2().Show();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz3x3().Show();
        }

        private void cadenaDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmString().Show(); 
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMatriz4x4().Show();
        }
    }
}
