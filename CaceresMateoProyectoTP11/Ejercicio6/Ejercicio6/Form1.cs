using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        private List<Persona> lista = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _nombre, _apellido;
            int _edad;
            _nombre = textBox1.Text;
            _apellido = textBox2.Text;
            _edad = int.Parse(textBox3.Text);

            Persona persona = new Persona(_apellido, _nombre, _edad);

            lista.Add(persona);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
