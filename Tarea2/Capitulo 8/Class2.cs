using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2.Capitulo_8
{
    class Ejercicios_8_5
    {
        static void Main(string[] args)
        {
            string cadena1 = " ", cadena2 = " ", conver = " ";
            char op = ' ';

            cadena1 = Console.ReadLine();
            cadena2 = Console.ReadLine();

            conver = string.Concat(cadena1, cadena2);

            var chars = conver.ToCharArray();

            int[] arr = new int[chars.Length];

            for (int i = 0; i < chars.Length; ++i)
            {
                arr[i] = chars[i];
            }
            Array.Sort(arr);

            for (int k = 0; k < chars.Length; ++k)
            {
                ch = Convert.ToChar(arr[k]);
                Console.WriteLine(ch);
            }


        }
    }
}
