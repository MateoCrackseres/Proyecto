using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej2
{
    class Program
    {
        static void Main(string[] args)
        {
            float pesos,dolares,euros;
            Console.Write("Ingrese la cantidad de pesos: ");
            pesos = float.Parse( Console.ReadLine());

            dolares = pesos / 300;

            euros = pesos / 350;

            Console.WriteLine("La cantidad en dolares es: " + dolares + " La cantidad en euros es: " + euros);

            Console.ReadKey();
        }
    }
}
