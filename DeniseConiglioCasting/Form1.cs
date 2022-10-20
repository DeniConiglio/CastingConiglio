using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeniseConiglioCasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbIngresar_Click(object sender, EventArgs e)
        {
            int Longitud = Convert.ToInt32(txtLongitud.Text);
            decimal pi = (decimal)3.14;
            decimal Diametro = (Longitud * pi)* (Longitud * pi);

            MessageBox.Show("Diametro: " + Diametro);

        }
    }
}
