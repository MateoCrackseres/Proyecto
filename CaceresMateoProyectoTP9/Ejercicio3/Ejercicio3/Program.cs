using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(5.75);

            Console.WriteLine("El Circulo tiene un Radio de 5,75\n\n");

            Console.WriteLine("El Perímetro del Circulo es: " + circulo.calcularPerimetro());
            Console.WriteLine("La Superficie del Circulo es: " + circulo.calcularArea());

            Console.ReadKey();
        }
    }
}
