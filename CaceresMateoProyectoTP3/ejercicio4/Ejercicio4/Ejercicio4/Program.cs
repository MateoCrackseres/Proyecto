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
        {/* Diseñe un programa que lea un numero de tres cifras y determine si es o no capicúa*/
            int num;
            Console.WriteLine("Ingrese un numero de tres cifras");
            num = int.Parse(Console.ReadLine());
            if (num >= 10000)
            {
                Console.WriteLine("El numero tiene mas de 3 Digitos");
            }
            if (num < 10000 && (num - num % 100) / 100 == num % 10)
            {
                Console.WriteLine("El numero es capicua");
            }
            if (num < 10000 && (num - num % 100) / 100 != num % 10)
            {
                Console.WriteLine("El numero no es capicua");
            }

            Console.ReadKey();
        }

    }
}
