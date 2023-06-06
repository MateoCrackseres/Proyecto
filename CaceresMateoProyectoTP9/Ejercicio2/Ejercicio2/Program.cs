using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 12;
            Cuadrilatero figura = new Cuadrilatero(50,70);

            valor = figura.calcularPerimetro();

            Console.WriteLine("El perimetro del cuadrilatero es: "+valor);
            Console.WriteLine("El area es: "+figura.calcularArea());
            if (figura.esUnCuadrado()==true)
            {
                Console.WriteLine("\nEs un cuadrado");
            }
            else
            {
                Console.WriteLine("\nNO es un cuadrado");
            }

            Console.ReadKey();
        }
    }
}
