using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(double d)
        {
            //string linea = "";
            string[] aux = new string[16];
            int numero = (int)d;
            int pos = 0;
            StringBuilder sb = new StringBuilder();
            do
            {
                if (numero % 2 != 0)
                {
                    //linea = linea + "1";
                    aux[pos] = "1";
                    pos++;
                }
                else
                {
                    //linea = linea + "0";
                    aux[pos] = "0";
                    pos++;
                }


                numero = numero / 2;

            } while (numero != 0);

            Array.Reverse(aux); //invierto el Array de string
            //string binario = string.Format("{0}",aux);

            for (int i = 0; i < aux.Length; i++)
            {
                sb.Append("" + aux[i]);
            }

            //return linea;            
            return sb.ToString(); ;
        }

        public static double BinarioDecimal(string s)
        {
            char[] cadena = s.ToCharArray();
            Array.Reverse(cadena);
            double resultado = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == '1')
                    resultado += Math.Pow(2, i);
            }
            return resultado;
        }
    }
}
