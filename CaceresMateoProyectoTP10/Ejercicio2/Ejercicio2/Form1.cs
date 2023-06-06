namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            float resultadodiv;
            float resultadomult;
            int resultadosuma;
            int resultadoresta;

            num1 = int.Parse(numero1.Text);
            num2 = int.Parse(numero2.Text);

            resultadodiv = num1 / num2;
            resultadomult = num1 * num2;
            resultadosuma = num1 + num2;
            resultadoresta = num1 - num2;

            suma.Text = resultadosuma.ToString();
            resta.Text = resultadoresta.ToString();
            mult.Text = resultadomult.ToString();
            division.Text = resultadodiv.ToString();
        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}