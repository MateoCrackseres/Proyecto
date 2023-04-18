using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcular las calificaciones de un grupo de alumnos. La nota final de cada alumno se
            *calcula según el siguiente criterio: se promediarán las notas obtenidas en la parte
            *práctica; la parte de problemas y la parte teórica. El programa leerá el nombre del
            *alumno, las tres notas obtenidas, mostrará el resultado por pantalla, y a continuación
            *volverá a pedir los datos del siguiente alumno hasta que el nombre sea una cadena
            *vacía. Las notas deben estar comprendidas entre 0 y 10, y si no están dentro de ese
            *rango no se imprimirá el promedio y se mostrará un mensaje de error.*/
            string alumno;
            float notaprac, notaprob, notateor, sumanota=0, promedio=0;
            bool band = false;
            do{
            Console.Write("Ingrese el nombre del alumno: ");
            alumno = Console.ReadLine();
            if (alumno == "")
            {
                Console.Write("\n///No se ha detectado un nombre valido, terminando el programa...///");
                break;
            }
            Console.Write("Ingrese la nota de dicho alumno en la parte practica: ");
            notaprac = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de la parte problemas: ");
            notaprob = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota de la parte teorica: ");
            notateor = float.Parse(Console.ReadLine());
                if((notaprac<0||notaprac>10)||(notaprob<0||notaprob>10)||(notateor<0||notateor>10)){
                    Console.Write("\n///Una o varias de las notas ingresadas esta en el rango incorrecto///");
                    break;
                }
            sumanota = notaprac + notaprob + notateor;
            promedio = sumanota / 3;
            Console.Write("\n\nEl promedio del alumno "+alumno+" es: "+promedio);
            Console.Write("\n------Ingrese los datos del siguiente alumno------\n\n");
            }
            while(band==false);
            Console.ReadKey();
        }
    }
}
