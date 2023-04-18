using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida una frase y el programa deberá mostrar la frase con un espacio entre
            *cada letra. Por Ejemplo, si se introduce la frase “Hola Mundo” deberá mostrar “H o l a M u n d o”.*/
            string frase;
            Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine();
            foreach (char letra in frase)
            {
                Console.Write(letra + " ");
            }
            Console.ReadKey();
        }
    }
}
