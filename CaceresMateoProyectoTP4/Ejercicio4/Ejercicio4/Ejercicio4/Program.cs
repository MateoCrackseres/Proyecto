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
            /*Realizar un programa que pida una frase o palabra, si la frase o palabra es de 4 caracteres de largo, el programa le concatenara un signo
             * de exclamacion al final, y si no es de 4 caracteres el programa le concatenara un signo de interrogacion al final. El programa mostrará la frase final*/
            string palabraof;
            int lon;
            Console.Write("Ingrese una palabra o frase: ");
            palabraof = Console.ReadLine();
            lon = palabraof.Length;
            if (lon <= 4)
            {
                Console.WriteLine(palabraof + "!");
            }
            else
            {
                Console.WriteLine(palabraof + "?");
            }

            Console.ReadKey();
        }
    }
}
