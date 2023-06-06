namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void variable_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boton_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = variable.Text;
            mensaje.Text = "Ahora estas en la Matrix, " + nombre;
            
        }

        private void mensaje_Click(object sender, EventArgs e)
        {

        }
    }
}