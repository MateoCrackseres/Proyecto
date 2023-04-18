using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que pida un numero y determine si ese numero es par o impar. Mostrar por pantalla un mensaje que indique
             * si el numero es par o impar. (para que un numero sea par, se debe dividir entre dos y su resto debe ser igual a 0*/
            int num;
            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            if(num%2==0){
                Console.WriteLine("El numero es par ");
            }
                else{
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
