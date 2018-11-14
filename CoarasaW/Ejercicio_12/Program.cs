using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje 
             * "¿Continuar? (S/N)". En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones. 
             * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
             */

            Console.Title = "Ejercicio_12";

            int numero, acumulador = 0;
            string caracter;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            do
            {
                Console.Write("Ingrese un Número : ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    acumulador = acumulador + numero;
                }
                else
                {
                    Console.WriteLine("Error al ingresar numero, vuelva a ingresar (Pulse una tecla)");
                    Console.ReadKey();
                }
                Console.Write("\nDesea [S]i Salir sino pulse otra tecla  : ");
                caracter = Console.ReadLine();
            }
            while (!ValidarRespuesta.Validar(caracter));
            Console.ResetColor();
            Console.WriteLine("Valor sumado :{0}", acumulador);
            Console.ReadKey();
        }
    }
}
