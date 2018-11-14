using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Mostrar por pantalla todos los números primos que haya hasta el número que ingrese 
             el usuario por consola.
             Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
             */
            Console.Title = "Ejercicio_03";
            int num, i, j, contador;
            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < num; i++)
            {
                contador = 0;
                for (j = 1; j <= num; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                    Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine("Pulsar una tecla para Finalizar !!!");
            Console.ReadLine();
        }
    }
}
