using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej11
{
    class Program
    {
        static void Main(string[] args)
        {

            int ni, nf;
            Console.Write("Ingrese un numero inicial: ");
            ni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero final: ");
            nf = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros entre ambos son: ");
            for (int i = ni+1; i < nf; i = i + 1)
            {
                Console.Write(+i+" ");
            }
            Console.ReadKey();
        }
    }
}
