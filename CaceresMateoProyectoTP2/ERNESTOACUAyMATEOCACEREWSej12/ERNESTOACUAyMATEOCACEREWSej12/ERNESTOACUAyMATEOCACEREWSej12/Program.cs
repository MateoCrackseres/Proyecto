using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            float raizc,raizcu;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            raizc = (float)(Math.Sqrt(numero));
            raizcu = (float)(Math.Pow(numero,1/3));
            Console.WriteLine("La raiz cuadrada es: " + raizc);
            Console.WriteLine("La raiz cubica es: " + raizcu);

            Console.ReadKey();
        }
    }
}
