using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_22";

            #region Atributos
            int opcion = 0;
            String numero;
            #endregion

            while (opcion != 4)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1.- Decimal a Binario.");
                Console.WriteLine("2.- Binario a Decimal.");
                Console.WriteLine("3.- (Suma, Resta y Comparación) - Binario y Decimal.");

                Console.WriteLine("4.- Salir");
                Console.Write("Ingrese la opción deseada: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Out.WriteLine("Escribe un numero en base 10: ");
                            numero = Console.ReadLine();
                            Console.WriteLine("El numero en binario es: {0}", Conversor.DecimalBinario(double.Parse(numero)));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            Console.Out.Write("\nEscribe un numero en binario: ");
                            numero = Console.ReadLine();
                            Console.WriteLine("El numero en decimal es: {0}", Conversor.BinarioDecimal(numero));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        {
                            Console.Out.Write("\nEscribe un numero en binario: ");
                            string binario = Console.ReadLine();
                            Console.Out.Write("Escribe un numero en base 10: ");
                            double numero2 = double.Parse(Console.ReadLine());

                            NumeroBinario bin;  //=new NumeroBinario (binario);
                            NumeroDecimal dec;  //=new NumeroDecimal (numero2);

                            bin = (NumeroBinario)binario;
                            dec = (NumeroDecimal)numero2;

                            string b = (string)bin;
                            double d = (double)dec;

                            string resultado = binario + numero2;
                            double resultado2 = dec + bin;

                            Console.WriteLine("Expicit - NumeroBinario bin = (NumeroBinario)binario; : {0}", bin.numero);
                            Console.WriteLine("Expicit - NumeroDecimal dec = (NumeroDecimal)numero2; : {0}", dec.numero);
                            Console.WriteLine("Implicit - string b = (string)bin;: {0}", b);
                            Console.WriteLine("Implicit - double d = (double)dec;: {0}", d);

                            Console.WriteLine("Suma - NumeroDecimal + NumeroBinario : {0}", resultado2);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        {
                            break;
                        }
                }
            }
        }
    }
}
