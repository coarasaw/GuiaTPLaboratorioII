using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        /*
          Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de 'n' empleados de una fábrica.
          Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
          hay que sumarle la cantidad de años trabajados multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
          Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar
          de todos los empleados ingresados. 
          Nota: Utilizar estructuras repetitivas y selectivas.
         */
        static void Main(string[] args)
        {
            int valor, antiguedad, horas;
            double bruto, total, descuentos;
            string nombre, seguir;

            Console.Title = "Ejercicio Nro 8";

            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Ingrese el nombre del empleado          : ");
                nombre = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Ingrese el valor de la hora del empleado: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese las horas trabajadas del empleado: ");
                horas = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese la antiguendad del empleado      : ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                bruto = valor * horas + antiguedad * 150;

                descuentos = bruto * 0.13;

                total = bruto - descuentos;

                Console.WriteLine("El empleado {0} cobra un sueldo bruto de {1:C}", nombre, bruto);
                Console.WriteLine("El cual persive una suma de {0:C} en descuentos", descuentos);
                Console.WriteLine("Por lo que el empleado recibe una suma total de {0:C}", total);
                Console.WriteLine("");
                Console.ResetColor();
                Console.WriteLine("Desea seguir? si/no");
                seguir = Console.ReadLine();
               
            }
            while (seguir.Equals("si"));
           
        }
    }
}
