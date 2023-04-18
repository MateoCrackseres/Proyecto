using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que pida 3 notas y valide si esas notas están entre 1 y 10. Si están entre esos
             *parámetros se debe poner en verdadero una variable de tipo lógico y si no ponerla en falso. Al final el
             *programa debe decir si las 3 notas son correctas usando la variable de tipo lógico.*/
            int nota1,nota2,nota3;
            bool verif1 = false, verif2 = false, verif3 = false;
            Console.Write("Ingrese la primer nota -> ");
            nota1 = int.Parse(Console.ReadLine());
            if(nota1>1&&nota1<10){
                verif1 = true;
            }
            Console.Write("Ingrese la segunda nota -> ");
            nota2 = int.Parse(Console.ReadLine());
            if(nota2>1&&nota2<10){
                verif2 = true;
            }
            Console.Write("Ingrese la tercer nota -> ");
            nota3 = int.Parse(Console.ReadLine());
            if(nota3>1&&nota3<10){
                verif3 = true;
            }

            if ((verif1 && verif2 && verif3) == true)
            {
                Console.WriteLine("\n\nLas 3 notas son correctas");
            }
            else
            {
                Console.WriteLine("\n\nAlguna de las 3 notas o las tres son incorrectas");
            }
            Console.ReadKey();
        }
    }
}
