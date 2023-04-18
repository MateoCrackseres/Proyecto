using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un hombre desea saber si su sueldo es mayor al sueldo minimo, el programa le pedira al usuario su sueldo actual y el sueldo minimo. Si el sueldo es mayor al minimo se debe mostrar
             un mensaje por pantalla indicandolo*/

            float sueldomin, sueldoact;
            Console.WriteLine("Ingrese su sueldo actual: ");
            sueldoact = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el sueldo minimo : ");
            sueldomin = float.Parse(Console.ReadLine());
            if (sueldoact > sueldomin)
            {
                Console.WriteLine("Su sueldo es mayor al sueldo minimo");
            }
            else
            {
                Console.WriteLine("Su sueldo es menor al minimo");
            }
            Console.ReadKey();

        }
    }
}
