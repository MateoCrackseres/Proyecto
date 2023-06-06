using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca, marcaproce;
            int ram, almacenamiento;
            Console.WriteLine("De que marca es la computadora?: ");
            marca=Console.ReadLine();
            Console.WriteLine("Que procesador tiene?: ");
            marcaproce=Console.ReadLine();
            Console.WriteLine("De cuanta memoria ram dispone?: ");
            ram=int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto espacio de almacenamiento tiene?: ");
            almacenamiento=int.Parse(Console.ReadLine());

            Console.Write("\n\n");

            Computadora pc = new Computadora(marca,marcaproce,ram,almacenamiento);
            Console.WriteLine("La marca de la computadora es: " + pc.Marca+"\n");
            Console.WriteLine("Su procesador es de marca: " + pc.Marcaproce + "\n");
            Console.WriteLine("Tiene: " + pc.Memram + "gb de memoria ram\n");
            Console.WriteLine("Su almacenamiento es de: " + pc.Almacenamiento + "gb\n");

            Console.ReadKey();
        }
    }
}
