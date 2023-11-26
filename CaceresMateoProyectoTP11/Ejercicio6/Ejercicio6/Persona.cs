using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Persona
    {
        private string apellido;
        private string nombre;
        private int edad;

        public Persona()
        {

        }
        public Persona(string apellido, string nombre, int edad)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
