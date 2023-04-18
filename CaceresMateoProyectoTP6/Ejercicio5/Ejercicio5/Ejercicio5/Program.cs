using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que calcule la suma de los N primeros números naturales. El valor de N se leerá por
            *teclado.*/
            int limite,suma=0;
            Console.Write("Ingrese un limite entero: ");
            limite = int.Parse(Console.ReadLine());
            for (int i = 0; i < limite; i++)
            {
                suma += i;
            }
            Console.Write("La suma de los numeros naturales hasta el limite es: "+suma);
            Console.ReadKey();
        }
    }
}
