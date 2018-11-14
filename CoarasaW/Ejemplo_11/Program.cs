using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_11
{
    class Program
    {
        /*
            Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
            Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
            posea la siguiente firma: bool Validar(int valor, int min, int max):
            a. valor: dato a validar
            b. min y max: rango en el cual deberá estar la variable valor.
            Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            Nota: Utilizar variables escalares, NO utilizar vectores.
         */
        static void Main(string[] args)
        {
            Console.Title = "EJERCICIO_11";
            int numero,nummin=0,nummax=0, numpromedio = 0, contador = 0, min = -100, max = 100;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Ingrese un Número entre el siguiente rango[-100,100]: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (Validaciones.Validar(numero, min, max))
                    {
                        Console.WriteLine("Numero ingresado es : {0}", numero);
                        if (nummin== 0)
                        {
                            nummin = numero;
                        }
                        if (nummax == 0)
                        {
                            nummax = numero;
                        }
                        if (nummin > numero)
                        {
                            nummin = numero;
                        }
                        if (nummax < numero)
                        {
                            nummax = numero;
                        }
                        numpromedio = numpromedio + numero;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Numero ingresado fuera del rango (Pulse una tecla)");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Error al ingresar numero, vuelva a ingresar (Pulse una tecla)");
                    Console.ReadKey();
                }
            } while (contador <= 3);
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Valor minimo es {0} , valor maximo es {1} , valor promedio es {1} ", nummin, nummax, numpromedio);
            Console.ResetColor();
            Console.WriteLine("Fin - cantidad de numeros ingresados {0} (Pulse una tecla)", contador);
            Console.ReadKey();
        }
    }
}
