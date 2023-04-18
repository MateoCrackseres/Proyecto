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
            /*Escriba un programa que solicite dos números enteros (mínimo y máximo). A
            *continuación, se debe pedir al usuario que ingrese números enteros situados entre el
            *máximo y mínimo. Cada vez que un número se encuentre entre ese intervalo, se sumara
            *uno a una variable. El programa terminará cuando se escriba un número que no
            *pertenezca a ese intervalo, y al finalizar se debe mostrar por pantalla la cantidad de
            *números ingresados dentro del intervalo.*/
            int ni, nmax, nmin, iterador = 0;

            Console.Write("Escriba el numero minimo: ");
            nmin = int.Parse(Console.ReadLine());
            Console.Write("Escriba el numero maximo: ");
            nmax
                = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Ingrese un numero: ");
                ni = int.Parse(Console.ReadLine());
                iterador++;
            }
            while (ni > nmin && ni < nmax);
            Console.Write("/!\\Se ingresó un numero fuera de los limites");
            Console.WriteLine("\n\nEl iterador acumuló un total de "+iterador+" respuestas correctas");
            Console.ReadKey();
        }
    }
}
