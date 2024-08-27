using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba22Ago
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCongruencial_Click(object sender, EventArgs e)
        {
            FormCongruencial ventana = new FormCongruencial();
            ventana.ShowDialog();
        }

        private void btnCuadradoMedio_Click(object sender, EventArgs e)
        {
            FormCuadradoMedio ventana = new FormCuadradoMedio();
            ventana.ShowDialog();
        }

        private void btnProductoMedio_Click(object sender, EventArgs e)
        {
            FormProductoMedio ventana = new FormProductoMedio();
            ventana.ShowDialog();
        }
    }
}
