namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void caja_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double disco, megas = 0;
            int cd = 0;
            disco = double.Parse(caja.Text);
            megas = disco * 1024;
            do
            {
                if (megas > 700)
                {
                    cd++;
                    megas -= 700;
                }
            } while (megas > 700);
            cds.Text = "Cantidad de CDs requeridos: " + cd.ToString();
        }
    }
}