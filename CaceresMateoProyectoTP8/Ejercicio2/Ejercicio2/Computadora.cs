using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Computadora
    {
        private string marca;
        private string marcaproce;
        private int memram;
        private int almacenamiento;

        public Computadora(string marca, string marcaproce, int memram, int almacenamiento)
        {
            this.Marca = marca;
            this.Marcaproce = marcaproce;
            this.Memram = memram;
            this.Almacenamiento = almacenamiento;
        }

        public string Marcaproce { get => marcaproce; set => marcaproce = value; }
        public int Memram { get => memram; set => memram = value; }
        public int Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
