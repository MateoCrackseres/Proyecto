using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej8
{
    class Program
    {
        static void Main(string[] args)
        {
            float fah, cel;
            Console.Write("Ingrese los grados Fahrenheit:  ");
            fah = float.Parse(Console.ReadLine());
            cel = (fah - 32) * 5 / 9;
            Console.Write(" La cantidad de grados en Celsius son:  "+cel);
            Console.ReadKey();




        }
    }
}