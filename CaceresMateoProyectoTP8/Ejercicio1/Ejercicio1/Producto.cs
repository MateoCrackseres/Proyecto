using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Producto
    {
        private int codigo;
        private string descripcion;
        private double precio;
        private int stock;
        private int v;

        public Producto(int cod, string desc, double prec, int stock)
        {
            this.codigo = cod;
            this.descripcion = desc;    
            this.precio = prec; 
            this.stock = stock;
        }
       
        public int Codigo 
        {
            get { return codigo; }

            set { codigo = value; }

        }
        public string Descripcion 
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio 
        {
            get { return precio; }
            set
            {
                precio = value;
            }

        }
        public int Stock
        { 
            get { return stock; 
            } set {  stock = value; }
        }
    }
}
