using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int edad = int.Parse(txtEdad.Text);

                string datos = nombre + " " + apellido + " " + " " + edad;

                try
                {
                 
                    string archivo = "datos.txt";

                    
                    using (StreamWriter writer = new StreamWriter(archivo, true))
                    {
                        writer.WriteLine(datos);
                    }

                    MessageBox.Show("Los datos se guardaron correctamente en el archivo.", "Guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            

        }
    }
}
