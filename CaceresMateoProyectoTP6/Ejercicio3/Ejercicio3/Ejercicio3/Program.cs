using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un docente de Programación tiene un listado de 3 notas registradas por cada uno de sus N estudiantes.
            La nota final se compone de un trabajo práctico Integrador (35%), una Exposición (25%) y un Parcial (40%).
            El docente requiere los siguientes informes claves de sus estudiantes:
                ▪ Nota promedio final de los estudiantes que reprobaron el curso. Un estudiante reprueba el curso si
                tiene una nota final inferior a 6.5.
                ▪ Porcentaje de alumnos que tienen una nota de integrador mayor a 7.5.
                ▪ La mayor nota obtenida en las exposiciones.
                ▪ Total, de estudiantes que obtuvieron en el Parcial entre 4.0 y 7.5.
            El programa pedirá la cantidad de alumnos que tiene el docente y en cada alumno pedirá las 3 notas y
            calculará todos informes claves que requiere el docente.*/
            int cant=0,ar=0,al=0,ap=0;
            float auxnotatpi = 0,auxauxntpi,auxnotaexp,auxauxnexp,auxnotapar,auxauxnpar;
            float sumare = 0,naux = 0,promediorep=0,auxalumnos,porc=0;

            Console.Write("Ingrese la cantidad de alumnos que desea obtener las notas: ");
            cant = int.Parse(Console.ReadLine());

            float[] notatpi = new float[cant+1];
            float[] notaexp = new float[cant+1];
            float[] notapar = new float[cant+1];
            float[] suma = new float[cant+1];

            for (int i = 1; i <= cant; i++)
            {

                Console.Write("\nIngrese la nota del trabajo practico integrador del alumno " + i + " ");
                auxnotatpi = float.Parse(Console.ReadLine());
                if (auxnotatpi < 7.5)//Porcentaje de alumnos que tienen una nota mayor a 7.5 en el trabajo practico integrador
                {
                    al++;
                }
                auxauxntpi = (float)(auxnotatpi * 0.35);
                notatpi[i] = auxauxntpi;
                Console.Write("\nIngrese la nota de la exposición del alumno " + i + " ");
                auxnotaexp = float.Parse(Console.ReadLine());
                if (auxnotaexp > naux)//La nota mas alta de la parte exposición
                {
                    naux = auxnotaexp;
                }
                auxauxnexp = (float)(auxnotaexp * 0.25);
                notaexp[i] = auxauxnexp;
                Console.Write("\nIngrese la nota del parcial del alumno " + i + " ");
                auxnotapar = float.Parse(Console.ReadLine());
                if (auxnotapar > 4.0 && auxnotapar < 7.5)//Alumnos que tienen una nota entre 4.0 y 7.5 en el parcial
                {
                    ap++;
                }
                auxauxnpar = (float)(auxnotapar * 0.40);
                notapar[i] = auxauxnpar;
                suma[i] = notapar[i] + notaexp[i] + notatpi[i];
                if (suma[i] < 6.5)//Alumnos que reprobaron
                {
                    ar++;
                    sumare += suma[i];
                }
                Console.Write("\n\n");
            }

            auxalumnos = cant - al;
            porc = auxalumnos * 100 / cant;//Porcentaje de alumnos que tienen una nota mayor a 7.5 en el trabajo practico integrador
            promediorep = sumare / ar;//Promedio de alumnos que reprueban

            Console.Write("Nota promedio final de los alumnos que reprobaron el curso: " + promediorep + "\n");
            Console.Write("Porcentaje de alumnos que tienen una nota de integrador mayor a 7.5.: " + porc + "\n");
            Console.Write("Mayor nota obtenida en las exposiciones: " + naux + "\n");
            Console.Write("Total de alumnos que obtuvieron una nota entre 4.0 y 7.5  en el parcial: " + ap + "\n");

            Console.ReadKey();
        }
    }
}
