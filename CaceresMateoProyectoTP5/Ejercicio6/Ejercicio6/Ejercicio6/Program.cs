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
            /*Escriba un programa que solicite al usuario números decimales mientras que el usuario
            *escriba números mayores al primero que se ingresó. Por ejemplo: si el usuario ingresa
            *como primer número un 3.1, y luego ingresa un 4, el programa debe solicitar un tercer
            *número. El programa continuará solicitando valores sucesivamente mientras los valores
            *ingresados sean mayores que 3.1, caso contrario, el programa finaliza.*/
            float dec, numero;
            int iterador = 0;
            Console.Write("Ingrese un numero decimal: ");
            dec = float.Parse(Console.ReadLine());
            do
            {
                iterador++;
                Console.Write("[" + iterador + "]Ingrese un numero decimal: ");
                numero = float.Parse(Console.ReadLine());
            }
            while (numero >= dec);
            Console.Write("Se ingresó un numero menor al primer numero");
            Console.ReadKey();
        }
    }
}
