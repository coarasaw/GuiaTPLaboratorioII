using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        /*
        a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
        nombre, apellido y legajo a cada uno de ellos.
        b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
        c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
        iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
        el método de instancia Next de la clase Random.
        d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
        mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
        desaprobado".
        */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            Alumno alum1 = new Alumno(102099, "Coarasa", "Walter");
            Alumno alum2 = new Alumno(223069, "Corral", "Mariana");
            Alumno alum3 = new Alumno(120033, "Cristaldo", "Tamara");

            byte notaUno, notaDos, contador = 1;
            Console.Write("Ingrese la Primera nota del alumno {0} : ", contador);
            notaUno = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Ingrese la segunda nota del alumno {0} : ", contador);
            notaDos = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            alum1.Estudiar(notaUno, notaDos);
            contador++;

            byte notaUno2 = 0, notaDos2 = 0;
            Console.Write("Ingrese la Primera nota del alumno {0} : ", contador);
            notaUno2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Ingrese la segunda nota del alumno {0} : ", contador);
            notaDos2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            alum2.Estudiar(notaUno2, notaDos2);
            contador++;

            byte notaUno3 = 0, notaDos3 = 0;
            Console.Write("Ingrese la Primera nota del alumno {0} : ", contador);
            notaUno3 = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Ingrese la segunda nota del alumno {0} : ", contador);
            notaDos3 = byte.Parse(Console.ReadLine());
            Console.WriteLine("");
            alum3.Estudiar(notaUno3, notaDos3);

            //alum1.Estudiar(8, 9);
            //alum2.Estudiar(6, 8);
            //alum3.Estudiar(2, 3);

            alum1.CalcularFinal();
            alum2.CalcularFinal();
            alum3.CalcularFinal();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Alunmo 1:\n{0}", alum1.Mostrar());
            Console.WriteLine("Alunmo 2:\n{0}", alum2.Mostrar());
            Console.WriteLine("Alumno 3:\n{0}", alum3.Mostrar());

            Console.ResetColor();
            Console.WriteLine("Pulse una tecla para terminar");
            Console.ReadKey();
        }
    }
}
