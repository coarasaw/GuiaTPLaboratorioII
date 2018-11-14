using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        /*
         Escribir un programa que determine si un año es bisiesto.
         Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
         también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
         Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";
            int i, año;
            Console.Write("Ingrese un año para saber cuales fueron sus anteriores años biciestos: ");
            año = int.Parse(Console.ReadLine());

            for (i = 1900; i < año; i++)
            {
                if (i % 4 == 0 && (i % 400 == 0 || i % 100 != 0))
                    Console.WriteLine("El año {0} es biciesto", i);
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
