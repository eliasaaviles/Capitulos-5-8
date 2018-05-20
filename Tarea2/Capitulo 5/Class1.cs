using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2.Capitulo_5
{
    class Ejercicios_5_4
    {
        static void Main(string[] args)
        {
            int n = 0, x = 1;

            Console.WriteLine("Digite el numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                x *= i;
            }
            Console.WriteLine(x);
        }
        

    }
}
