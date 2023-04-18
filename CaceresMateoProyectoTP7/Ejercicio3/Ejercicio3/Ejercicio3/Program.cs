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
            /*Realizar un programa que rellene un vector de tamaño N, con valores ingresados por el usuario. A continuacion,
             * se debe buscar un elemento dentro del arreglo (el numero a buscar tambien debe ser ingresado por el usuario).
             * El programa debe indicar la posicion donde se encuentra el valor. En caso que el numero se encuentre repetido dentro del arreglo
             * se debe imprimir todas las posiciones donde se encuentre ese valor. Finalmente, en caso que el numero a buscar no este
             * dentro del arreglo se debe mostrar un mensaje.*/
            
            int cantidad = 0;
            int numeroencontrar;
            bool band = false;

            Console.Write("ingrese el valor del tamaño del vector: ");
            cantidad = int.Parse(Console.ReadLine());

            int[] numero = new int[cantidad];

            for(int i=0; i < cantidad; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero[i]=int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.Write("\n¿Que numero desea encontrar en el arreglo? : ");
            numeroencontrar = int.Parse(Console.ReadLine());

            for(int i = 0; i < cantidad; i++)
            {
                if (numero[i] == numeroencontrar)
                {
                    band = true;
                    Console.Write("El numero " + numeroencontrar + " se encuentra en la posicion " + i + " del arreglo\n");
                }

            }
            if (band == false)
            {
                Console.Write("En numero no se encontro en el arreglo ");
            }
            Console.ReadKey();
        }
    }
}
