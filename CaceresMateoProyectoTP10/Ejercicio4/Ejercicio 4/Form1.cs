namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verif_Click(object sender, EventArgs e)
        {
            char caracter;
            bool voc = false;
            caracter = char.Parse(letra.Text);
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' || caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U')
            {
                voc = true;
                vocal.Text = "Es una vocal!";
            }
            else
            {
                vocal.Text = "No es una vocal!";
            }

        }

        private void vocal_Click(object sender, EventArgs e)
        {

        }
    }
}