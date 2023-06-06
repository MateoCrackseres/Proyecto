using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Cuadrilatero
    {
        private int largo;
        private int alto;

        

        public Cuadrilatero()
        {

        }
        public Cuadrilatero(int a, int b)
        {
            this.alto = a;
            this.largo = b;
        }

        public void setLargo(int largo)
        {
            this.largo = largo;
        }
        public int getLargo()
        {
            return (this.largo);
        }
        //Metodo mas corto
        public int Alto { get => alto; set => alto = value; }

        public int calcularPerimetro()
        {
            return (2 * (this.largo + this.alto));
            /*O
             * return(2*(this.getLargo()+this.Alto))*/
        }
        public int calcularArea()
        {
            return(this.largo * this.alto);
        }
        public bool esUnCuadrado()
        {
            if(this.largo == this.alto)
            {
                return (true);
            }
            else
            {
                return (false);
            }
            /*Operador ternario:
            return (this.alto == this.largo ? true : false);
            */
        }
    }
}
