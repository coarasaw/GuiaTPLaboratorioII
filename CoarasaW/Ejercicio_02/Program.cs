using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar 
             que el número sea mayor que cero, caso contrario, mostrar el mensaje:
             "ERROR. ¡Reingresar número!". Nota: Utilizar el método ‘Pow’ de la clase Math para
             realizar la operación.
             */

            Console.Title = "Ejercicio_02";
            double resultado, numero = 0;
            int cuadrado = 2;
            int cubo = 3;

            Console.Write("Ingrese un numero :");
            numero = int.Parse(Console.ReadLine());
            while (numero == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.Write("Ingrese un numero :");
                numero = int.Parse(Console.ReadLine());
            }

              
            resultado = Math.Pow(numero, cuadrado);
            Console.WriteLine("");
            Console.WriteLine("Numero ingresado " + numero + " elevada a " + cuadrado + " potencia es " + resultado);
            Console.WriteLine("");
            resultado = Math.Pow(numero, cubo);
            Console.WriteLine("Numero ingresado " + numero + " elevada a " + cubo + " potencia es " + resultado);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Finalizar pulsando una tecla !!!");
            Console.ReadLine();
        }
    }
}
