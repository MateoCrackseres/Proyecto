using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        { /*Se pide ingresar una letra del alfabeto y mostrar si dicha letra es vocal o consonant*/
            char letra;
          
            Console.WriteLine(" Introduzca una letra");
            letra = char.Parse(Console.ReadLine());
            if (letra == 'a'||letra=='e'||letra=='i'||letra=='o'||letra=='u'){
                Console.WriteLine("La letra que ingresó es vocal");
            }
                else {
                    Console.WriteLine("La letra que ingresó es consonante");
                }
            
            Console.ReadKey();

               
        }
    }
}
