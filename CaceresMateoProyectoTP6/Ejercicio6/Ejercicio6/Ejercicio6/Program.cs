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
            /*Siguiendo el ejercicio 20 de los ejercicios principales, ahora deberemos hacer lo mismo pero que la
            *cadena se muestre al revés. Por ejemplo, si tenemos la cadena: “Hola Mundo”, deberemos mostrar “o d n u
            *M a l o H”.*/
            string frasex;
            char[] frase = new char[999];
            int largo,i=0;
            Console.Write("Ingrese una frase: ");
            frasex = Console.ReadLine();
            largo = frasex.Length;
            foreach(char letra in frasex){
                frase[i]=letra;
                i++;
            }

            for (int j = largo; j >= 0; j--)
            {
                Console.Write(frase[j] + " ");
                if (j == largo)
                {
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
        
    }
}
