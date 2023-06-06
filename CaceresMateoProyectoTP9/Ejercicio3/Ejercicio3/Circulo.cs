using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Circulo
    {
        private double PI = 3.14;
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public double calcularArea()
        {
            return PI * radio * radio;
        }

        public double calcularPerimetro()
        {
            return 2 * PI * radio;
        }
    }
}
