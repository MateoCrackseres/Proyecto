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

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private List<Mascota> list = new List<Mascota>();
        StreamWriter archivo = new StreamWriter("datosmascotas.txt");
        public Form1()
        {
            InitializeComponent();
        }
        /*Si el control checkbox esta seleccionado al presionar el boton guardar, los datos se guardaran en un archivo de texto llamado datosmascotas.txt,
         * caso contrario si el checkbox esta destildado al hacer click en el boton guardar los datos se guardaran en una lista. El boton nuevo tiene como funcion limpiar
         * los controles para un nuevo ingreso de datos*/
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, especie, dueño;
            nombre = txtNombre.Text;
            especie = txtEspecie.Text;
            dueño = txtDueño.Text;

            if (chbArchivo.Checked && nombre != "" && especie != "" && dueño != "")
            {
                archivo.WriteLine(nombre + " " + especie + " " + dueño + "\n");
                archivo.Close();
            }
            else if (chbArchivo.Checked && nombre == "" || especie == "" || dueño == "")
            {
                MessageBox.Show("Ingrese datos válidos o rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Mascota mascota = new Mascota(nombre,especie,dueño);
            list.Add(mascota);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDueño.Text = "";
            txtEspecie.Text = "";
            txtNombre.Text = "";
            chbArchivo.Checked = false;
        }
    }
}
