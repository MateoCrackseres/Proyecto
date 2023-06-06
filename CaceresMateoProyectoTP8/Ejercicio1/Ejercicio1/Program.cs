using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto Codigo = new Producto(253626767, "Queso cremoso", 500, 5);

            Console.WriteLine("Codigo: "+Codigo.Codigo);
            Console.WriteLine("Descripcion: "+Codigo.Descripcion);
            Console.WriteLine("Precio: "+Codigo.Precio);
            Console.WriteLine("Stock: "+Codigo.Stock);



            Console.ReadKey();
        }
    }
}
