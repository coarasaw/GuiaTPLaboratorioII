using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int _cantidadSumas;

        public Sumador()
        {
            this._cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas) : this()
        {
            this._cantidadSumas = cantidadSumas;
        }

        //b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
        //     i. En el caso de Sumar(long, long) sumará los valores numéricos 
        //     ii.En el de Sumar(string, string) concatenará las cadenas de texto. Antes de continuar, 
        //         agregar un objeto del tipo Sumador en el Main y probar el código. 

        public long Sumar(long a, long b)
        {
            this._cantidadSumas++;
            return (a + b);
        }

        public string Sumar(string a, string b)
        {
            string s = string.Format("{0} + {1}", a, b);
            return s;
        }
        //    c. Generar una conversión explícita que retorne cantidadSumas. 
        //    d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor. 
        //    e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.
        //       Agregar un segundo objeto del tipo Sumador en el Main y probar el código.

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (s1._cantidadSumas == s2._cantidadSumas);
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return (s1._cantidadSumas + s2._cantidadSumas);
        }
    }
}
