using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que calcule el cuadrado de los 9 primeros números naturales e imprima por
            *pantalla el número seguido de su cuadrado. Ejemplo: “2 elevado al cuadrado es igual a 4”, y así
            *sucesivamente.*/
            Console.Write("///PROGRAMA QUE MUESTRA EL CUADRADO DE LOS PRIMEROS NUMEROS NATURALES///\n\n");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("El cuadrado de " + i + " es " + (i * i) + "\n");
            }
            Console.ReadKey();
        }
    }
}
