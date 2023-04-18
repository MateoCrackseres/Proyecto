using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERNESTOACUAyMATEOCACEREWSej4
{
    class Program
    {
        static void Main(string[] args)
        {
            float segundos,minutos,horas;
            Console.Write("Ingrese la cantidad de segundos: ");
            segundos = float.Parse(Console.ReadLine());
            minutos = segundos / 60;
            horas = minutos / 60;
            Console.WriteLine("La cantidad de horas es: "+horas+" La cantidad de minutos es: "+minutos);

            Console.ReadKey();
        }
    }
}