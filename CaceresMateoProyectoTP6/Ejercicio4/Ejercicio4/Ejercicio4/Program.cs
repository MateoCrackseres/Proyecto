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
            /*Realizar un programa que muestre la cantidad de números que son múltiplos de 2 o de 3 comprendidos
            *entre 1 y 100.*/
            int l = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    l++;
                }
            }
            Console.Write("Cantidad de numeros multiplos de 2 o 3 entre 1 y 100: " + l);
            Console.ReadKey();
        }
    }
}
