using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej7
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, alturap, basep, perimetro;
            Console.Write("Ingrese la base del paralelogramo: ");
            basep = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el altura del paralelogramo: ");
            alturap = float.Parse(Console.ReadLine());

            perimetro = (basep * 2) + (alturap * 2);
            area = basep * alturap;

            Console.WriteLine("El perimetro es: " + perimetro + " y el area es: " + area);
            Console.ReadKey();
        }
    }
}
