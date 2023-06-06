using System.Runtime.InteropServices;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private int canti;
        private double resultado;
        private double numero;
        private double suma;
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            canti = int.Parse(datos.Text);
            if (canti <= 0)
            {
                Close();
            }
            datos.Enabled = false;
            boton.Enabled = false;
            textbox2.Enabled = true;
            btnEnviar2.Enabled = true;
            label2.Enabled = true;
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            double descuento;
            i++;
            numero = int.Parse(textbox2.Text);
            suma += numero;
            textbox2.Text = " ";
            if (i == canti)
            {
                textbox2.Enabled = false;
                btnEnviar2.Enabled = false;
                label3.Enabled = true;
                label1.Enabled = true;
                if (canti > 10 && canti < 20)
                {
                    descuento = suma * 0.10;
                    resultado = descuento + suma;
                    pfinal.Text = resultado.ToString();
                    ptotal.Text = suma.ToString();
                }
                else if (canti > 20)
                {
                    descuento = suma * 0.20;
                    resultado = descuento + suma;
                    ptotal.Text = suma.ToString();
                    pfinal.Text = resultado.ToString();
                }
                else if (canti < 10)
                {
                    ptotal.Text = suma.ToString();
                    pfinal.Text = suma.ToString();
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}