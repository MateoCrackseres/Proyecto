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
            /*Realiza un programa que solo permita introdicir los caracteres 'S'y'N'. Si el usuario ingresa alguno de estos dos caracteres se deberá de imprimir
             * por pantalla que diga "CORRECTO", en caso contrario, se deberá imprimir "INCORRECTO".*/
            char respuesta;
            Console.Write("Ingrese 'S' o 'N': ");
            respuesta = char.Parse(Console.ReadLine());
            if (respuesta == 'S' || respuesta == 'N')
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }

            Console.ReadKey();
        }
    }
}
