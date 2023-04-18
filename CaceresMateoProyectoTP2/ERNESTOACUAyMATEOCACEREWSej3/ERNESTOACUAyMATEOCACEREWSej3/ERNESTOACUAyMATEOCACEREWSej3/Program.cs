using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej3
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario,salariofinal,salariofinal2;
            Console.Write(" Ingrese su salario");
            salario = float.Parse(Console.ReadLine());
            salariofinal = salario * 20 / 100;
            salariofinal2 = salario - salariofinal;
            Console.WriteLine(" Su salario final es: "+ salariofinal2);

            Console.ReadKey();

        }
    }
}
