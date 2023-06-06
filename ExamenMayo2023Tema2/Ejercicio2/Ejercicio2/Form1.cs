using System.Runtime.InteropServices;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            int cantidad, i = 1;
            double[] precio=new double[999];
            double aux;

            cantidad = int.Parse(datos.Text);

            while(i<(cantidad+1))
            {
                texto.Text = "Ingrese el precio del producto " + i + ":";
                aux = double.Parse(datos.Text);
                i++;

            }
        }
    }
}