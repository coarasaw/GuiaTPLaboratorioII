using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una pirámide como la siguiente:
                * 
               *** 
              ***** 
             ******* 
            ********* 
            Nota: Utilizar estructuras repetitivas y selectivas.*/

            int i, j = 0, Número;
            bool val;

            Console.Title = "EJERCICIO Nº 10";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Ingrese un número: ");
            val = int.TryParse(Console.ReadLine(), out Número);
            Console.ResetColor();

            while (val == false)
            {
                Console.WriteLine("ERROR, reingrese: ");
            }

            Console.WriteLine("");//SALTO
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (i = 0; i < Número; i++)//CANTIDAD DE RENGLONES
            {
                for (int k = 0; k < (80 - j) / 2; k++)//ESPACIOS EN BLANCO (CENTRAR EN PANTALLA)
                {
                    Console.Write(" ");
                }

                for (j = 0; j <= 2 * i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Fin, Pulse una Tecla.!!!");
            Console.ReadKey();
        }
    }
}
