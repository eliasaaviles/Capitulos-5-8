using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2.Capitulo_7
{
    class Ejercicios_7_1
    {
        static void Main(string[] args)
        {


            System.Collections.ArrayList calfs = new System.Collections.ArrayList();

            int cantEstudiantes = 0, comp = 0;
            float calificacion = 0, min = 0, max = 0, prom = 0;
            string con;

            Console.WriteLine("Digite la cantidad de estudiantes: ");
            cantEstudiantes = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < cantEstudiantes; ++x)
            {
                Console.WriteLine("Ingrese la calificacion del estudiante: ");
                calificacion = Convert.ToSingle(Console.ReadLine());
                calfs.Add(calificacion);

                con = calfs[x].ToString();
                comp = Convert.ToInt32(con);

                if (comp > max)
                {
                    max = comp;
                }

                if (x == 0)
                {
                    min = comp;
                }
                else if (x > 0 && comp < min)
                {
                    min = comp;
                }
                prom += comp;
            }

            Console.WriteLine("La menor calificacion es: " + min);
            Console.WriteLine("La mayor calificacion es: " + max);
            Console.WriteLine("El prom de las calificaciones es: " + prom / cantEstudiantes);

        }
    }
}
