using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * AutoF1:
                a. Al generar un auto se cargará enCompetencia como falso y cantidadCombustible y
                vueltasRestantes en 0.
                b. Dos autos serán iguales si el número y escudería son iguales.
                c. Realizar los métodos getters y setters para cantidadCombustible, enCompetencia y
                vueltasRestantes
                Competencia:
                d. El constructor privado será el único capaz de inicializar la lista de competidores.
                e. La sobrecarga + agregará un competidor si es que aún hay espacio (validar con
                cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y
                AutoF1).
                f. Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad
                de vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un
                número random entre 15 y 100 a cantidadCombustible.
                Generar los métodos en el Main para probar el código.
             */
            Console.Title = "Ejercicio_30";

            Competencia c = new Competencia(10, 10);
            AutoF1 a1 = new AutoF1(1, "Fiat");
            AutoF1 a2 = new AutoF1(2, "Ford");
            AutoF1 a3 = new AutoF1(3, "Renault");
            AutoF1 a4 = new AutoF1(4, "Honda");
            AutoF1 a5 = new AutoF1(4, "Honda");

            Console.WriteLine("Son iguales los autos {0}\n{1} \n{2} ", a4==a5,a4.Mostrar(),a5.Mostrar());
            Console.WriteLine("------------------------------------------------");

            if (c + a1)
            {
                Console.WriteLine("Se Agregó un Auto");
            }
            if (c + a2)
            {
                Console.WriteLine("Se Agregó un Auto");
            }
            if (c + a3)
            {
                Console.WriteLine("Se Agregó un Auto");
            }
            if (c + a4)
            {
                Console.WriteLine("Se Agregó un Auto");
            }
            Console.WriteLine("------------------ Competencia -----------------");
            Console.WriteLine(c.MostrarDatos());

            Console.WriteLine("------------------------------------------------");
            Console.ReadKey();
        }
    }
}
