using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida introducir solo frases o palabras de 6 caracteres. Si el usuario ingresa una frase o palabra de 6 caracteres
             * se debera de imprimir un mensaje por pantalla que diga "CORRECTO", en caso contrario, se debera imprimir "INCORRECTO".*/
            string fop;
            int ta;
            Console.Write("Introduzca una frase o palabra: ");
            fop = Console.ReadLine();
            ta = fop.Length;

            if (ta <= 6)
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
