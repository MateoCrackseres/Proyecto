using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        StreamReader guia = new StreamReader("GuiaTelefonica.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telefono, _guia;
            bool found = false;
            string[] campos = new string[2];
            guia = File.OpenText("GuiaTelefonica.txt");
            telefono=textBox1.Text;
            _guia = guia.ReadLine();
            while(_guia!=null && found == false)
            {
                campos = _guia.Split('');
                if (campos[0].Trim().Equals(telefono))
                {
                    textBox2.Text = campos[1].Trim();
                    found=true;
                }
                if(found == false)
                {
                    MessageBox.Show("El numero de telefono ingresado es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                guia.Close();
                break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
