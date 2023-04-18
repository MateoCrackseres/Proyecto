using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej9
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo,sueldof1,sueldof2,sueldofin1,sueldofin2;
            Console.Write("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());

            sueldof1 = (float)(sueldo * 0.10);
            sueldof2 = (float)(sueldo * 0.30);
            sueldofin1 = sueldof1 + sueldo;
            sueldofin2 = sueldof2 + sueldo;
            Console.WriteLine("El sueldo mas el 10% es: "+sueldofin1);
            Console.WriteLine("El sueldo final sumando las comisiones es: "+sueldofin2);
            Console.ReadKey();
        }
    }
}
