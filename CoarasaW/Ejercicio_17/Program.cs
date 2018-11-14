using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
                en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
                b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo
                retornarán el valor del mismo).
                c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
                i. tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo
                (gastar tinta)
                ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
                0 y menor o igual a cantidadTintaMaxima.
                d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
                e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
                de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
                f. El método Pintar(int, out string) restará la tinta gastada (reutilizar código SetTinta), sin
                poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0).
                También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
                tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
                10 "***".
                g. Utilizar todos los métodos en el Main.
                h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
                bolígrafo.
                Nota: Crear el constructor que crea conveniente. La clase Boligrafo y el Program deben estar en
                namespaces distintos.
             */

            Console.Title = "Ejercicio_17";

            string dibujo = "";

            Boligrafo b1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo b2 = new Boligrafo(ConsoleColor.Red, 50);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Boligrafo uno ");
            Console.Write("Cantidad de tinta "+Boligrafo.Mostrar(b1));
            Console.WriteLine("");


            if (b1.Pintar(80, out dibujo))
            {
                Console.WriteLine("Se pinto la cantidad de \n" + dibujo);
                Console.WriteLine();
            }
            else
                Console.WriteLine(dibujo);
            //
            Console.WriteLine("Cantidad de color que queda es " + Boligrafo.Mostrar(b1));
            short cantidad = b1.GetTinta();
            if (cantidad <= 0)
            {
                Console.WriteLine("No se pudo pintar mas !!!");
            }

            if (b1.Pintar(10, out dibujo))
            {
                Console.WriteLine("Se pinto la cantidad de \n" + dibujo);
                Console.WriteLine();
            }
            else
                Console.WriteLine(dibujo);
            //
            Console.WriteLine("Cantidad de color que queda es " + Boligrafo.Mostrar(b1));
            cantidad = b1.GetTinta();
            if (cantidad <= 0)
            {
                Console.WriteLine("No se pudo pintar mas !!!");
            }

            if (b1.Pintar(20, out dibujo))
            {
                Console.WriteLine("Se pinto la cantidad de \n" + dibujo);
                Console.WriteLine();
            }
            else
                Console.WriteLine(dibujo);
            //
            Console.WriteLine("Cantidad de color que queda es " + Boligrafo.Mostrar(b1));
            cantidad = b1.GetTinta();
            if (cantidad <= 0)
            {
                Console.WriteLine("No se pudo pintar mas !!!");
            }

            Console.ResetColor();

            Console.WriteLine("*");


            /*-------------- Boligrafo II ----------------------------------*/
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Boligrafo dos ");
            Console.Write("Cantidad de tinta " + Boligrafo.Mostrar(b2));
            Console.WriteLine("");

            dibujo = "";
            if (b2.Pintar(55, out dibujo))
            {
                Console.WriteLine("Se pinto la cantidad de " + dibujo);
                Console.ResetColor();
                Console.WriteLine();
            }
            else
                Console.WriteLine(dibujo);

            Console.WriteLine("Cantidad de color que queda es " + Boligrafo.Mostrar(b2));

            cantidad = b2.GetTinta();
            if (cantidad <= 0 )
            {
                Console.WriteLine("No se pudo pintar mas !!!");
            }
            Console.ResetColor();
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
