using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: 
             el valor máximo, el valor mínimo y el promedio.
             */
            Console.Title = "Ejercicio_01";
            int acumular = 0;
            int maximo = 0;
            int minimo = 0;
            int Lee = 0;
            int promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introducir un numero : ");
                Lee = Convert.ToInt32(Console.ReadLine());

                if (maximo == 0 && minimo == 0)
                {
                    minimo = Lee;
                    maximo = Lee;
                }

                if (Lee < minimo)
                    minimo = Lee;

                if (Lee > maximo)
                    maximo = Lee;

                acumular = acumular + Lee;
            }


            promedio = acumular / 2;
            Console.WriteLine("Minimo {0}", minimo);
            Console.WriteLine("Maximo {0}", maximo);
            Console.WriteLine("Acumulado {0}", acumular);
            Console.WriteLine("Promedio {0}", promedio);
            Console.ReadKey();
        }
    }
}
