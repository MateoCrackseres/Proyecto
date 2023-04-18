using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecricio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación
            *solicite números al usuario hasta que la suma de los números introducidos supere el
            *límite inicial.*/
            int limite;
            float sumatotal=0,numero;
            Console.Write("Ingrese un limite positivo: ");
            limite = int.Parse(Console.ReadLine());
            while (sumatotal < limite)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());
                sumatotal += numero;
            }
            Console.WriteLine("-----La suma de los numeros ha superado el limite positivo-----");
            Console.ReadKey();
        }
    }
}
