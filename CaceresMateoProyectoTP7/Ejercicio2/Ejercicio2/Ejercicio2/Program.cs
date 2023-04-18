using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Relaizar un programa que lea 10 numeros reales por teclado, los almacene en un arereglo y los muestre por pantalla la suma,
             * resta y multiplicacion de todos los numeros ingresados al arreglo*/
            float[] vector = new float[10];
            double suma = 0, multiplicacion = 1;
            float resta = 0;
            Console.Write("Ingrese 10 numeros reales: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero real: ");
                vector[i] = float.Parse(Console.ReadLine());
                if (i < 1)
                {
                    resta = vector[i] + vector[i];
                }
                suma += vector[i];
                resta -= vector[i];
                multiplicacion *= vector[i];
            }
            Console.Write("Suma= " + suma + "\n" + "Resta= " + resta + "\n" + "Multiplicacion= " + multiplicacion);
            Console.ReadKey();
        }
    }
}
