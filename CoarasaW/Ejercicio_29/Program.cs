using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Crear una Clase llamada Jugador y otra Equipo con la siguiente estructura:
             *  Jugador:
                a. Todos los datos estadísticos del Jugador se inicializarán en 0 dentro del constructor privado.
                b. El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
                c. MostrarDatos retornará una cadena de string con todos los datos y estadística del Jugador.
                d. Dos jugadores serán iguales si tienen el mismo DNI.
                Equipo:
                e. La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
                f. La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista
                aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo
                cantidadDeJugadores.
                Generar los métodos en el Main para probar el código.
             */
            Console.Title = "Ejercicio_29";
            Equipo e1 = new Equipo(22, "Boca Jr");
            Equipo e2 = new Equipo(23, "Independiente");
            Equipo e3 = new Equipo(21, "Chacarita");

            Jugador j1 = new Jugador(23456789, "Garcia", 24, 19);
            Jugador j2 = new Jugador(453229987, "Barrios", 3, 30);
            Jugador j3 = new Jugador(323456455, "Perez");
            Jugador j4 = new Jugador(323456455, "Perez");

            if (e1 + j1)
                Console.WriteLine("Boca Agregó a {0}\n", j1.MostrarDatos());
            else { Console.WriteLine("Boca Agregó no a {0}\n", j1.MostrarDatos()); }

            Console.WriteLine("------------------------------------------------");
            if (e2 + j2)
                Console.WriteLine("Independiente agregó a {0}\n", j2.MostrarDatos());
            else { Console.WriteLine("Independiente no agregó a {0}\n", j2.MostrarDatos()); }

            Console.WriteLine("------------------------------------------------");
            if (e3 + j3)
                Console.WriteLine("Sarmiento agregó a {0}\n", j3.MostrarDatos());
            else { Console.WriteLine("Sarmiento no agregó a {0}\n", j3.MostrarDatos()); }

            Console.WriteLine("------------------------------------------------");
            if (e3 + j4)
                Console.WriteLine("Sarmiento agregó a {0}\n", j4.MostrarDatos());
            else { Console.WriteLine("Sarmiento no agregó a {0}\n", j4.MostrarDatos()); }

            Console.ReadKey();
        }
    }
}
