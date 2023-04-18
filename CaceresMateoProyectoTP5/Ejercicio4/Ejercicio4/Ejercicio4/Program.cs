using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa en el cual se ingrese un número y mientras ese número sea mayor
            *de 10, se pedirá el número de nuevo.*/
            int numero=11;
            while (numero > 10)
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }
            Console.Write("El numero es menor a 10");
            Console.ReadKey();
        }
    }
}
