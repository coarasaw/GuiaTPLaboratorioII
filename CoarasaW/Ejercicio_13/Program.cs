using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
             string DecimalBinario(double). Convierte un número de decimal a binario.
             double BinarioDecimal(string). Convierte un número binario a decimal.
             */
            Console.Title = "Ejercicio_13";

            #region Atributos
            int opcion = 0;
            String numero;
            #endregion
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            while (opcion != 3)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1.- Decimal a Binario.         ");
                Console.WriteLine("2.- Binario a Decimal.         ");
                Console.WriteLine("3.- Salir                      ");
                Console.WriteLine();
                Console.Write("Ingrese la opción deseada:      ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Out.WriteLine("Escribe un numero en base 10: ");
                            numero = Console.ReadLine();
                            Console.WriteLine("El numero en binario es: {0}       ", Conversor.DecimalBinario(double.Parse(numero)));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            Console.Out.Write("\nEscribe un numero en binario: ");
                            numero = Console.ReadLine();
                            Console.WriteLine("El numero en decimal es: {0}    ", Conversor.BinarioDecimal(numero));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            break;
                        }
                }
            }
            Console.ResetColor();
        }
    }
}
