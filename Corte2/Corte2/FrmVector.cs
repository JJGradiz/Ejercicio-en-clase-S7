using Corte2.Modelos;
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
    public partial class FrmVector : Form
    {
        Vector vector = new Vector();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vector.Agregar(int.Parse(tbNota.Text));
            lblMsn.Text = vector.Show();

        }

        public FrmVector()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVector_Load(object sender, EventArgs e)
        {

        }

       
    }
}
