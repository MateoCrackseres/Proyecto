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
            /*Realizar un programa que rellene un vector de 5 valores ingresados por el usuario y los muestre por pantalla*/
            int[] vector = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresa 5 valores por teclado: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0 ; i < 5; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }

    }
}
