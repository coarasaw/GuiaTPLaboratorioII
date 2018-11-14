using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    public class NumeroBinario
    {
        public string numero;

        public NumeroBinario(string numero)
        { this.numero = numero; }


        //i. string + (NumeroBinario, NumeroDecimal)
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double resultado = (Conversor.BinarioDecimal(b.numero)) + d.numero;
            string binario = Conversor.DecimalBinario(resultado);
            return binario;
        }
        //ii. double - (NumeroDecimal, NumeroBinario) 
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double resultado = (Conversor.BinarioDecimal(b.numero)) - d.numero;
            string binario = Conversor.DecimalBinario(resultado);
            return binario;
        }
        //iii. bool == (NumeroDecimal, NumeroBinario) 
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return (d.numero == (Conversor.BinarioDecimal(b.numero)));
        }
        //iv. bool != (NumeroDecimal, NumeroBinario) 
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        { return !(b == d); }

        //  e. NumeroBinario objBinario = "1001";
        public static implicit operator string(NumeroBinario b)
        {
            return b.numero;
        }

        //  g. (string)objBinario 
        public static explicit operator NumeroBinario(string linea)
        {
            NumeroBinario num = new NumeroBinario(linea);
            return num;
        }
    }
}
