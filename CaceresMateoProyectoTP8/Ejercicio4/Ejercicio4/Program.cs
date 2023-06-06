using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro("Olivia", "Bulldog Fances", 14.3, 3);

            perro.mostrarInfo();

            Console.ReadKey();
        }
    }
}
