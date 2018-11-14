using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";
            /*
            Realizar una aplicación de consola.Agregar la clase Sumador. 

                a.Crear dos constructores:
                    i.Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros. 
                    ii.Sumador() inicializa cantidadSumas en 0.Reutilizará al primer constructor.
                b.El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
                    i.En el caso de Sumar(long, long) sumará los valores numéricos
                    ii.En el de Sumar(string, string) concatenará las cadenas de texto.Antes de continuar, 
                       agregar un objeto del tipo Sumador en el Main y probar el código.

                c.Generar una conversión explícita que retorne cantidadSumas.
                d.Sobrecargar el operador + (suma)para que puedan sumar cantidadSumas y retornen un long con dicho valor. 
                e.Sobrecargar el operador | (pipe)para que retorne True si ambos sumadores tienen igual cantidadSumas.
                   Agregar un segundo objeto del tipo Sumador en el Main y probar el código.
            */
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Sumador s1 = new Sumador(11);//Cuando uso el método sumar se incrementa y quedan iguales
            Sumador s2 = new Sumador(12);

            long resultado = s1.Sumar(10, 25);
            string resultado2 = s1.Sumar("10", "25");
            long suma = s1 + s2;

            Console.WriteLine("Resultado long       : " + resultado);
            Console.WriteLine("Resultado string     : " + resultado2);
            Console.WriteLine("Resultado Suma de obj: " + resultado);

            if (s1 | s2)
                Console.WriteLine("Las cantidades son iguales!!!");
            else { Console.WriteLine("Las cantidades no son iguales!!!"); }
         
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
