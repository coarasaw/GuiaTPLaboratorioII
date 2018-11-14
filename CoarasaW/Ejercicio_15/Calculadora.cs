using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static int Calcular(int op1, int op2, string c)
        {
            int resultado = 0;
            switch (c)
            {
                case "+":
                    resultado = op1 + op2;
                    break;
                case "-":
                    resultado = op1 - op2;
                    break;
                case "*":
                    resultado = op1 * op2;
                    break;
                case "/":
                    if (Validar(op2))
                        resultado = op1 / op2;
                    else
                        Console.WriteLine("Division por Cero / Incorrecta");
                    break;
                default:
                    Console.WriteLine("Operacion incorrecta");
                    break;
            }
            return resultado;
        }

        private static bool Validar(int b)
        {
            if (b != 0)
                return true;
            return false;
        }

        public static void Mostrar(int resultado)
        {
            if (resultado != 0)
            {
                Console.WriteLine("El resultado de la operacion es {0}", resultado);
            }
            //Console.WriteLine("");
            //Console.WriteLine("Pulsar una tecla para Finalizar !!!");
            //Console.ReadLine();
        }
    }
}
