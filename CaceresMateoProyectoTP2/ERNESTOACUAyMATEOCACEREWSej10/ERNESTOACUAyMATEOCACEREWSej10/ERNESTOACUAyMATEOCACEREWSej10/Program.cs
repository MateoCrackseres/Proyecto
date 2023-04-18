using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej10
{
    class Program
    {
        static void Main(string[] args)
        {
            float compra, total, totalf;
           Console.Write("El total de la compra es"  );
            compra = float.Parse(Console.ReadLine());
            total = (float) (compra * 0.15);
            totalf = (float)(compra - total);
            Console.WriteLine("El precio con el 15% de descuento es:" + totalf);
            Console.ReadKey();











        }
    }
}
