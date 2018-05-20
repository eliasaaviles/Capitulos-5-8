using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2.Capitulo_8
{
    class Ejercicios_8_3
    {
        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;

            Console.WriteLine("Fecha y Hora: {0: h:mm:ss}", DateTime.Now);
            Console.WriteLine("Fecha y Hora: {0: HH:mm:ss}", DateTime.Now);
            Console.WriteLine("La fecha de hoy es: " + thisDay.ToString());

            Console.ReadKey();

        }
    }
}
