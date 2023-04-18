using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Construir un programa que permita ingresar un numero, si el numero es mayor a 500, se debe calcular y mostrar en pantalla 
             * el 18% de éste*/
            int num;
            float numfi;
            Console.Write("Escriba un numero entero: ");
            num = int.Parse(Console.ReadLine());
            if (num > 500)
            {
                numfi = (float)(num * 0.18);
                Console.WriteLine("El 18% de dicho numero es: " + numfi);
            }
            else
            {
                Console.WriteLine("Su numero no es mayor a 500");
            }
            Console.ReadKey();

        }
    }
}
