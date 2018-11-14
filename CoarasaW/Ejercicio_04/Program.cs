using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
             (excluido el mismo) que son divisores del número.
             El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
             Escribir una aplicación que encuentre los 4 primeros números perfectos.
             Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
             */
            Console.Title = "Ejercicio_04";
            int suma = 0, cont = 0;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" Los primeros cuatro numero perfectos ");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 2; ; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        suma = suma + j;
                    }
                }
                if (suma == i)
                {
                    Console.WriteLine("El numero {0} es un numero perfecto", i);
                    cont++;
                }

                suma = 0;
                if (cont == 4)
                    break;
            }

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" Pulsar una tecla para Finalizar !!!  ");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
