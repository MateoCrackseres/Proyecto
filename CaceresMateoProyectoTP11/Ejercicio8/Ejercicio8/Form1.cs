using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        private Random numrandom = new Random();
        private int random;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            random = numrandom.Next(0, 10);
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            
                numero = int.Parse(textBox1.Text);
                if (numero != random)
                {
                    lblError.Visible = true;
                    textBox1.Clear();   
                }
                else
            {
                lblError.Visible = false;
                lblExito.Visible = true;
                button1.Enabled = false;
                textBox1.Enabled = false;
            }
        }
    }
}
