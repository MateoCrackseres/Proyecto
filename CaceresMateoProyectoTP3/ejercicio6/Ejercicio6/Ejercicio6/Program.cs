using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*La politica de cobro de la empresa telefonica CELphone es, Cuando se realiza una llamada, el cobro por el tiempo que ésta dura,
             * de tal forma que el costo por minuto es uniforme y es de 30 pesos; además, se carga un impuesto del 3% cuando es domingo,
             * y si es otro dia, en el turno de la mañana 15% y en el turno de la tarde 10%. Realiza un programa para determinar
             * cuanto debe pagar una persona que realiza una llamada, el usuario debe ingresar los minutos que duró la llamada, el día y el turno.*/
            int cobro = 30;
            int minutos,auxd,total,totalt;
            string dia,turno;
            Console.Write("------ASISTENTE DE PAGO CELphone------");
            Console.Write("\n\nIngrese los minutos que duró su llamada: ");
            minutos = int.Parse(Console.ReadLine());

            Console.Write("\n¿Que dia fue la llamada?: ");
            dia = Console.ReadLine();

            Console.Write("\nY, ¿En que turno?: ");
            turno = Console.ReadLine();
            total = minutos * cobro;

            if (dia == "Domingo" || dia == "domingo")
            {
                auxd = (total * 3) / 100;
                totalt = total + auxd;
                Console.Write("El total a pagar es: " + totalt + " pesos");
            }
            else
            {
                if (turno == "Tarde" || turno == "tarde")
                {
                    auxd = (total * 10) / 100;
                    totalt = total + auxd;
                    Console.Write("El total a pagar es: " + totalt + " pesos");
                }
                else
                {
                    if (turno == "Mañana" || turno == "mañana")
                    {
                        auxd = (total * 15) / 100;
                        totalt = total + auxd;
                        Console.Write("El total a pagar es: " + totalt + " pesos");
                    }
                }
            }
       

            Console.ReadKey();
        }
    }
}
