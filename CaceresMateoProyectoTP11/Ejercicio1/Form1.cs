using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaceresMateoTP11
{
    public partial class Form1 : Form
    {
        private int cantidad = 0;
        private int[] vector = new int[999];
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Enabled = true;
            lbl1.Text = "Especifique la amplitud del array";
            btn1.Visible = false;
            btn2.Visible = true;
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            cantidad = int.Parse(txt1.Text);
            for(int i = 0; i < cantidad;  i++)
            {
                vector[i] = random.Next(1, 100);
            }
            txt1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = true;
            txt3.Enabled = true;
            lbl2.Text = "Ingrese un numero";
            lbl1.Visible = false;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int cant=0;
            int encontrar;
            encontrar = int.Parse(txt3.Text);
            for(int i = 0; i < cantidad; i++)
            {
                if(encontrar == vector[i])
                {
                    cant++;
                }
            }
            txt3.Enabled = false;
            btn3.Enabled = false;
            lbl2.Visible = false;
            lbl3.Text = "La cantidad de veces\n que se repitio el numero es: " + cant;
        }
    }
}
