namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            double a, b, resul1, resul2;

            a = double.Parse(numero1.Text);
            b = double.Parse(numero2.Text);

            resul1 = (a + b) * (a - b);
            resul2 = (a * a) - (b * b);

            resultado1.Text = resul1.ToString();
            resultado2.Text = resul2.ToString();
        }
    }
}