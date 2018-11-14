using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ej21
{
    public class Celsius
    {
        private float _cantidad;

        public float Cantidad
        { get { return _cantidad; } }

        public Celsius()
        { }

        public Celsius(float cantidad)
        {
            this._cantidad = cantidad;
        }

        public static explicit operator Kelvin(Celsius c) //   K = (( C * (9/5) + 32 )+ 459.67) * 5/9 
        {
            float kelvin = ((c._cantidad * (9 / 5f) + 32) + 459.67f) * 5 / 9f;
            Kelvin k = new Kelvin(kelvin);
            return k;
        }

        public static explicit operator Fahrenheit(Celsius c) //   F = C * (9/5) + 32
        {
            float far = (c._cantidad * (9 / 5f)) + 32;
            Fahrenheit f = new Fahrenheit(far);
            return f;
        }

        public static Celsius operator +(Celsius c, Kelvin k) //Igualo las cantidades de acuerdo a las medidas
        {                                                     // //     C = ((K * 9/5 - 459.67)-32)/(9/5)
            Celsius cel = new Celsius(c._cantidad + ((k.Cantidad * 9 / 5f - 459.67f) - 32) / (9 / 5f));
            return c;
        }

        public static Celsius operator +(Celsius c, Fahrenheit f) //Igualo las cantidades de acuerdo a las medidas
        {                                                     //     C = (F-32) * 5/9
            Celsius cel = new Celsius(c.Cantidad + (f.Cantidad - 32) * 5 / 9f);
            return cel;
        }
    }
}
