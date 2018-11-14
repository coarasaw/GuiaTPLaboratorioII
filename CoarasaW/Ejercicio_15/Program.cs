using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";

            /*
            Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * ó /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea tres métodos estáticos (de clase):
            a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
            operación matemática. El método devolverá el resultado de la operación.
            b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
            TRUE si el número es distinto de CERO.
            c. Mostrar (público): Este método recibe como parámetro el resultado de la operación y lo
            muestra por pantalla. No posee valor de retorno. 
             */

            int numero1, numero2, resultado;
            string operacion, caracter;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            do
            {
                Console.Write("Ingrese un numero para realizar una operacion[1]: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese un numero para realizar una operacion[2]: ");
                numero2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la operacion a efectuar[+-*/]:            ");
                operacion = Console.ReadLine();

                resultado = Calculadora.Calcular(numero1, numero2, operacion);
                Calculadora.Mostrar(resultado);
                Console.Write("\nDesea [S]i Salir sino pulse otra tecla  :      ");
                caracter = Console.ReadLine();
                Console.Clear();
            }
            while (!ValidarRespuesta.Validar(caracter));
            Console.ResetColor();
            //Console.ReadLine();
        }
    }
}
