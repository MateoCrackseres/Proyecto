using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Perro
    {
        private string nombre;
        private string raza;
        private double peso;
        private int edad;

        public Perro(string nombre, string raza, double peso, int edad)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Peso = peso;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Edad { get => edad; set => edad = value; }

        public void mostrarInfo()
        {
            Console.WriteLine("----------- Datos del perro -----------");
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Raza: " + this.Raza);
            Console.WriteLine("Peso: " + this.Peso + "kg");
            Console.WriteLine("Edad: " + this.Edad + " Años");
        }
    }
}
