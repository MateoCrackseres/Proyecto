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
            /*Dada una secuencia de números ingresados por teclado que finaliza con la entrada de
            *un número negativo, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un
            *programa que calcule el promedio de los números ingresados.*/
            int ni = 1 , suma=0, iterador = -1;
            float prom;

            Console.Write("//El programa se detiene cuando se detecta un numero negativo//\n\n\n");
            while (ni > 0)
            {
                Console.Write("Ingrese un numero: ");
                ni = int.Parse(Console.ReadLine());
                suma += ni;
                iterador++;
            }
            prom = suma / iterador;
            Console.WriteLine("El promedio de los numeros ingresados es: " + prom);
            Console.ReadKey();
        }
    }
}
