using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double precio=0;
            double descuento=0;
            double final = 0;
            double iva=0;
            double ivafinal=0;
            precio = double.Parse(txtPrecio.Text);
            if (cmbDesc.SelectedIndex == 0)
            {
                descuento = precio * 0.20;
                final = precio - descuento;
                lblPF.Visible = true;
                lblPF.Text = final.ToString();
            }else if(cmbDesc.SelectedIndex == 1)
            {
                descuento = precio * 0.30;
                final = precio - descuento;
                lblPF.Visible = true;
                lblPF.Text = final.ToString();
            }
            else if (cmbDesc.SelectedIndex == 2)
            {
                descuento = precio * 0.50;
                final = precio - descuento;
                lblPF.Visible = true;
                lblPF.Text = final.ToString();
            }
           

            if (rdbiva21.Checked)
            {
                iva = final*0.21;
                ivafinal = final + iva;
                lblPF.Text = ivafinal.ToString();
            }else if(rdbiva10.Checked)
            {
                iva = final * 0.10;
                ivafinal = final + iva;
                lblPF.Text = ivafinal.ToString();
            }
        }
    }
}
