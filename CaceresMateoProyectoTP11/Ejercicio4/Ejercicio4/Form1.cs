using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private string nombre;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            lbl2.Text = nombre.ToLower();
            lbl1.Text = nombre.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
