using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private int h = 0, m = 0, s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;
            etMostrar.Text = h + ":" + m + ":" + s;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                etMostrar.Text = h + ":" + m + ":" + s;
                s += 1;
                if (s == 60)
                {
                    m = m + 1;
                    s = 0;
                    if (m == 60)
                    {
                        h = h + 1;
                        m = 0;
                        if (h == 24)
                        {
                        h = 0;
                        m = 0;
                        s = 0;
                        }
                    }
                }
        }
    }
}
