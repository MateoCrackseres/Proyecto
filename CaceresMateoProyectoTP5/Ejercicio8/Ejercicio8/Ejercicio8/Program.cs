using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que calcule cuántos dígitos tiene un número entero positivo.
            *(pista: se puede hacer dividiendo varias veces entre 10).*/
            int numero, i=0;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero >= 1)
            {
                i++;
                numero /= 10;
            }
            Console.Write("El numero tiene un total de "+i+" numeros");
            Console.ReadKey();
        }
    }
}
