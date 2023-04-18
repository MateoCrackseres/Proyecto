using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej5
{
    class Program
    {
        static void Main(string[] args)
        {
            float area=0, perimetro, diagonal1,diagonal2,lado;
            Console.Write("Introducir el lado del rombo: ");

            lado = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la diagonal 1: ");
            diagonal1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la diagonal 1: ");
            diagonal2 = float.Parse(Console.ReadLine());
          
           
            area = diagonal1 * diagonal2 / 2;
            
            perimetro =lado * 4;

            Console.WriteLine("El area del rombo es: " + area + " El perimetro del rombo es: " + perimetro);




            Console.ReadKey();

        }
    }
}
