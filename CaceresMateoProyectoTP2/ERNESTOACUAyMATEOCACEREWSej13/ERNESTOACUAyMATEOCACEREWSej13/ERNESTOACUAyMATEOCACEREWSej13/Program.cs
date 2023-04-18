using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, aux, dec, uni;
            Console.WriteLine("Ingrese el numero de dos cifras:");
            num = int.Parse(Console.ReadLine());
            dec = num / 10;
            uni = num % 10;
            aux = (uni * 10) + dec;
            Console.WriteLine("El numero invertido es:" + aux);


        }
    }
}
