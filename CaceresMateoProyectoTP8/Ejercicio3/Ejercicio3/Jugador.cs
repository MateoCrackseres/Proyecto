using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Jugador
    {
        private string nombre;
        private int puntaje;
        private string nacionalidad;
        private int edad;

        public Jugador()
        {

        }
        public Jugador(string nombre, int puntaje, string nacionalidad, int edad)
        {
            this.Nombre = nombre;
            this.Puntaje = puntaje;
            this.Nacionalidad = nacionalidad;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
