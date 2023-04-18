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
           /*Escriba un programa que valide si una nota está entre 0 y 10, sino está entre 0 y 10 la nota se pedirá de
            *nuevo hasta que la nota sea correcta.*/
            int nota=11;
            while (nota < 0 || nota > 10)
            {
                Console.Write("Ingrese una nota: ");
                nota = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nota correcta");
            Console.ReadKey();
        }
    }
}
