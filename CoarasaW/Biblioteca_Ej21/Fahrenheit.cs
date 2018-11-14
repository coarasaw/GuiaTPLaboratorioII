using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ej21
{
    public class Fahrenheit
    {
        private float _cantidad;

        public float Cantidad
        { get { return _cantidad; } }

        public Fahrenheit()
        { }

        public Fahrenheit(float cantidad)
        {
            this._cantidad = cantidad;
        }

        public static explicit operator Kelvin(Fahrenheit f) //   K = (F + 459.67) * 5/9 
        {
            float kelvin = (f._cantidad + 459.67f) * 5 / 9;
            Kelvin k = new Kelvin(kelvin);
            return k;
        }

        public static explicit operator Celsius(Fahrenheit f) //  C = (F-32) * 5/9
        {
            float celsius = (f._cantidad - 32) * 5 / 9f;
            Celsius c = new Celsius(celsius);
            return c;
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k) //Igualo las cantidades de acuerdo a las medidas
        {
            Fahrenheit far = new Fahrenheit(f.Cantidad + (k.Cantidad * 9 / 5f - 459.67f)); //K = (F + 459.67) * 5/9
            return far;
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c) //Igualo las cantidades de acuerdo a las medidas
        {
            Fahrenheit far = new Fahrenheit(f.Cantidad + (c.Cantidad * (9 / 5f) + 32));   //F = C * (9/5) + 32
            return far;
        }
    }
}
