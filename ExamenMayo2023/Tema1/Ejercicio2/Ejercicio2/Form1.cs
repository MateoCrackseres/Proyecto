using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private double precio; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double total;
            total = precio / 2;
            pfinal.Text = total.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double total;
            total = precio * 0.35;
            pfinal.Text = total.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pfinal.Text = precio.ToString();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            precio = double.Parse(txtprecio.Text);
        }
    }
}
