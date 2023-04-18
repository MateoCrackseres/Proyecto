using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej6
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado,apotema,perimetro,area;
            Console.Write("Ingrese uno de sus lados: ");
            lado = float.Parse(Console.ReadLine());
            Console.Write("Agregue el Apotema: ");
            apotema = float.Parse(Console.ReadLine());
            perimetro = lado * 6;
            area = perimetro * apotema / 2;
            Console.WriteLine("El perimetro del hexagono es: "+perimetro);
            Console.WriteLine("El area del hexagono es: " + area);


            Console.ReadKey();
        }
    }
}
