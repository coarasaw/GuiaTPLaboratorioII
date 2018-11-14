using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerccio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
                a. double CalcularCuadrado(double)
                b. double CalcularTriangulo(double, double)
                c. double CalcularCirculo(double)
                El ingreso de los datos como la visualización se deberán realizar desde el método Main().
             */
            Console.Title = "Ejercicio_14";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("El area del cuadrado de 5 es {0}      ", CalculoDeArea.CalcularCuadrado(5));
            Console.WriteLine("El area del triangulo de (10,2) es {0}", CalculoDeArea.CalcularTriangulo(10, 2));
            Console.WriteLine("El area del circulo de (3) es {0}     ", CalculoDeArea.CalcularCirculo(3));
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Pulsar una tecla para Finalizar !!!");
            Console.ReadLine();
        }
    }
}
