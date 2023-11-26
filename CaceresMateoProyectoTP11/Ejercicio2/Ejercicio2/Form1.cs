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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "1234";
            string txt1, txt2;
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;

            if(txt1 != user || txt2 != pass)
            {
                label.Text = "*The user or password is incorrect, please try again";
            }
            else
            {
                Close();
            }
        }
    }
}
