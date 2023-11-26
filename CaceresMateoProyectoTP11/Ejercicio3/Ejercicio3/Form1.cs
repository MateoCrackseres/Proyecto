using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private int cant;
        private int i = 0;
        private double suma;
        private double[] vector = new double[999];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cant = int.Parse(cantidad.Text);
            txt1.Enabled = true;
            txt2.Enabled = true;
            btn2.Enabled = true;
            cantidad.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            i++;
            txt1.Clear();
            vector[i] = double.Parse(txt2.Text);
            suma += vector[i];
            label4.Text = "Cantidad total: " + suma;
            txt2.Clear();
            if (i == cant)
            {
                txt1.Enabled = false;
                txt2.Enabled = false;
                btn2.Enabled = false;
            }
        }
    }
}
