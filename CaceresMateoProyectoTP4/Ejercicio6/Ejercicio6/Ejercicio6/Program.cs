using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase es una ‘A’. Si la
            *primera letra es una ‘A’, se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
            *contrario, se deberá imprimir “INCORRECTO”.*/
            string frase;
            char primeral;
          
            Console.WriteLine("Ingrese una frase: ");
            frase = Console.ReadLine();
           

            frase = frase.Substring(0, 1);
           

            if (frase == "A")
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
