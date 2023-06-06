namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {

            int num;
            num = int.Parse(numero.Text);
            if (num == 1)
            {
                romano.Text = "I";
            }
            else if (num == 2)
            {
                romano.Text = "II";
            }
            else if (num == 3)
            {
                romano.Text = "III";
            }
            else if (num == 4)
            {
                romano.Text = "IV";
            }
            else if (num == 5)
            {
                romano.Text = "V";
            }
            else if (num == 6)
            {
                romano.Text = "VI";
            }
            else if (num == 7)
            {
                romano.Text = "VII";
            }
            else if (num == 8)
            {
                romano.Text = "VIII";
            }
            else if (num == 9)
            {
                romano.Text = "IX";
            }
            else if (num == 10)
            {
                romano.Text = "X";
            }
            if (num < 1 || num > 10)
            {
                romano.Text = " ";
                error.Text = "ERROR El numero ingresado no se encuentra dentro de los valores especificados.";
            }
            else
            {
                error.Text = " ";
            }

        }
    }
}