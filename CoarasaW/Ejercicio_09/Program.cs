using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        /*
         * Escribir un programa que imprima por pantalla una pirámide como la siguiente:
             * 
             *** 
             ***** 
             ******* 
             *********
         *El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. 
         *Para el ejemplo anterior la altura ingresada fue de 5. 
         *Nota: Utilizar estructuras repetitivas y selectivas.
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";
            int altura, i, j;

            Console.Write(" Ingrese altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());
            for (i = 0; i <= altura; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
