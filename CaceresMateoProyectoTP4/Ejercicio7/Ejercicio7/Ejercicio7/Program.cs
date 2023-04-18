using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Continuando el ejercicio anterior, ahora se pedirá una frase o palabra y se validará si la primera letra de
            *la frase es igual a la última letra de la frase. Se deberá de imprimir un mensaje por pantalla que diga
            *“CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”.*/
            string frase, primeral, ultimal;
            Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine();

            primeral = frase.Substring(0, 1);
            ultimal = frase.Substring((frase.Length - 1), 1);

            if (primeral == ultimal)
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();
        }
    }
}
