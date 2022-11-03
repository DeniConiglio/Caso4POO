using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaC4;
using LibreriaC4.Animales;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(5, 12, 20, "Blanco");
            MessageBox.Show(conejo.ImprimirComida());
        }

        private void btnLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(10, 20, 50, "Felino");
            MessageBox.Show(leon.ImprimirComida());
        }

        private void btnLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(10, 025, 5, "Ave");
            MessageBox.Show(loro.ImprimirComida());
        }
    }
}
