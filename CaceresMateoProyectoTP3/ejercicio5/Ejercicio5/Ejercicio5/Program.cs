using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cree una aplicacion que nos pida un dia de la semana y que nos diga si es un dia laboral o no.
            string dia;
            Console.Write("Escriba un dia de la semana: ");
            dia = Console.ReadLine();
            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("Dia laboral");
            }
            else
            {
                if (dia == "Lunes" || dia == "Martes" || dia == "Miercoles" || dia == "Jueves" || dia == "Viernes")
                {
                    Console.WriteLine("Dia laboral");
                }
                else
                {
                    Console.WriteLine("Dia de descanso");
                }
            }

                Console.ReadKey();
        }
    }
}
