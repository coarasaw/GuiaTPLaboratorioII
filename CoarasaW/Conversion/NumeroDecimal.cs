using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public class NumeroDecimal
    {
        public double numero;

        public NumeroDecimal(double numero)
        { this.numero = numero; }

        // i. double + (NumeroDecimal, NumeroBinario)  
        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double resultado = d.numero + (Conversor.BinarioDecimal(b.numero));
            return resultado;
        }
        // ii. double - (NumeroDecimal, NumeroBinario) 
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double resultado = d.numero - (Conversor.BinarioDecimal(b.numero));
            return resultado;
        }
        // iii. bool == (NumeroDecimal, NumeroBinario) 
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return (d.numero == (Conversor.BinarioDecimal(b.numero)));
        }
        // iv. bool != (NumeroDecimal, NumeroBinario) 
        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        { return !(d == b); }

        // Agregar conversiones implícitas para poder ejecutar: 

        //     f. NumeroDecimal objDecimal = 9;
        public static implicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }

        //     Agregar conversiones explícitas para poder ejecutar:

        //     h. (double)objDecimal 
        public static explicit operator NumeroDecimal(double d)
        {
            NumeroDecimal num = new NumeroDecimal(d);
            return num;
        }
    }
}
