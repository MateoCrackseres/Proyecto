using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            char letra;
            letra = char.Parse(txtbx.Text);

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'|| letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                texto.Text = "La letra es una vocal";
            }
            else
            {
                texto.Text = "La letra NO es una vocal";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
