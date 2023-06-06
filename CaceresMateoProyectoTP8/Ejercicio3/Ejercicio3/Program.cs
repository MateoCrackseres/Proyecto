using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador player = new Jugador();

            player.Nombre = "Juan";
            player.Puntaje = 140;
            player.Nacionalidad = "Argentina";
            player.Edad = 29;

            Console.WriteLine("Nombre: " + player.Nombre);
            Console.WriteLine("Puntaje: " + player.Puntaje);
            Console.WriteLine("Nacionalidad: " + player.Nacionalidad);
            Console.WriteLine("Edad: " + player.Edad);

            Console.ReadKey();
        }
    }
}
