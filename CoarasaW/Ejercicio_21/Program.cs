using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Ej21;
namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  21.Crear tres clases: Fahrenheit, Celsius y Kelvin.Realizar un ejercicio similar al anterior, 
             *  teniendo en cuenta que: 
             *  F = C * (9 / 5) + 32 
             *  C = (F - 32) * 5 / 9 F = K * 9 / 5 – 459.67 
             *  K = (F + 459.67) * 5 / 9
            */
            Console.Title = "Ejercicio_21";
            Kelvin k = new Kelvin(2f);
            Celsius c = new Celsius(5f);
            Fahrenheit f = new Fahrenheit(3f);

            Kelvin aux_k = k + f;
            Console.WriteLine("{0} Kelvin + {1} Fahrenheit: {2} Kelvin", k.Cantidad, f.Cantidad, aux_k.Cantidad);
            aux_k = k + c;
            Console.WriteLine("{0} Kelvin + {1} Celsius: {2} Kelvin", k.Cantidad, c.Cantidad, aux_k.Cantidad);
            Console.WriteLine("----------------------------------------------");

            Celsius aux_c = c + k;
            Console.WriteLine("{0} Celsius + Kelvin {1}: {2} Celsius", c.Cantidad, k.Cantidad, aux_c.Cantidad);
            aux_c = c + f;
            Console.WriteLine("{0} Celsius + Fahrenheit {1}: {2} Celsius", c.Cantidad, f.Cantidad, aux_c.Cantidad);
            Console.WriteLine("----------------------------------------------");

            Fahrenheit aux_f = f + k;
            Console.WriteLine("{0} Fahrenheit + Kelvin {1}: {2} Fahrenheit", f.Cantidad, k.Cantidad, aux_f.Cantidad);
            aux_f = f + c;
            Console.WriteLine("{0} Fahrenheit + Celsius {1}: {2} Fahrenheit", f.Cantidad, c.Cantidad, aux_f.Cantidad);
            Console.ReadKey();
        }
    }
}
