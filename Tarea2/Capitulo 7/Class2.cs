using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2.Capitulo_7
{
    class Ejercicios_7_5
    { 
        static void Main(string[] args)
        {

            System.Collections.Hashtable ht = new System.Collections.Hashtable();

        int op = 0, num = 0;
        string nombre = " ";
        char opc = ' ';

            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion:\n1-Insertar Contacto.\n2-Buscar Contacto\n3-Salir.");

                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("Escriba el nombre: ");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Escriba el numero: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            ht.Add(nombre, num);

                            Console.WriteLine("Desea agregar otro contacto? S | N: ");
                            opc = Convert.ToChar(Console.ReadLine());

                            if (opc == 's' || opc == 'S')
                            {
                                continue;
                            }
                            else if (opc == 'n' || opc == 'N')
                            {
                                break;
                            }

                        }

                        break;

                    case 2:
                        Console.Clear();

                        foreach (System.Collections.DictionaryEntry entry in ht)
                        {
                            Console.WriteLine("Nombre: " + entry.Key + " Numero: " + entry.Value);
                        }
                        Console.ReadKey();
                        break;
                }
                }
}
