using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
             dos grupos de números, cuyas sumas son iguales.
             El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
             cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
             49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
             Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
             usuario ingrese por consola.
             Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
             */

            Console.Title = "Ejercicio_05";
            double num, i, j, sumaAdelante, sumaAtras, cont = 1;

            Console.Write("Ingrese un numero por consola: ");
            num = double.Parse(Console.ReadLine());

            while (cont < num)
            {
                cont++;
                sumaAdelante = 0;
                sumaAtras = 0;

                for (i = 1; i < cont; i++)
                {
                    sumaAtras += i;
                }

                for (j = cont + 1; j < sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante += j;
                }

                if (sumaAdelante == sumaAtras)
                    Console.WriteLine("El numero {0} es un centro numerico", cont);
            }

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("  Pulsar una tecla para Finalizar !!! ");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
