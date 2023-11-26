using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Mascota
    {
        private string Nombre;
        private string Especie;
        private string Dueño;

        public Mascota(string Nombre, string Especie, string Dueño)
        {
            this.Nombre1 = Nombre;
            this.Especie1 = Especie;
            this.Dueño1 = Dueño;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Especie1 { get => Especie; set => Especie = value; }
        public string Dueño1 { get => Dueño; set => Dueño = value; }
    }
}
