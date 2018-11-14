using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        /*
          Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos 
          por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now).
          Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            // Variables
            DateTime nacimiento;
            DateTime hoy;
            TimeSpan dias;
            /*Con el TimeSpan tenemos una sencilla manera de medir el tiempo, por ejemplo 
             * para calcular la diferencia entre dos fechas
             */

            // Nacimiento
            Console.WriteLine();
            Console.Write("Ingrese fecha de nacimiento DD/MM/AAAA: ");
            nacimiento = DateTime.Parse(Console.ReadLine());
            // Hoy            
            hoy = DateTime.Now;
            Console.WriteLine("La fecha de hoy es: {0}", hoy);

            // cantidad de dias
            dias = hoy - nacimiento;
            Console.WriteLine("La cantidad de dias de vida vividos son: {0}", dias.Days);

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
