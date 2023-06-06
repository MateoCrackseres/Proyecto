using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero(1459);

            Console.WriteLine("El numero es Par: " + numero.esPar());
            Console.WriteLine("El numero es positivo: " + numero.esPositivo());
            Console.WriteLine("El numero es Multiplo de 3: " + numero.esMultiploDe(3));

            Console.ReadKey();
        }
    }
}
