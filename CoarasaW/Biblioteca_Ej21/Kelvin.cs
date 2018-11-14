using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ej21
{
    public class Kelvin
    {
        private float _cantidad;

        public float Cantidad
        { get { return _cantidad; } }

        public Kelvin()
        { }

        public Kelvin(float cantidad)
        { this._cantidad = cantidad; }

        public static explicit operator Fahrenheit(Kelvin k) // F = K * 9/5 – 459.67 
        {
            float fahrenheit = k._cantidad * 9 / 5f - 459.67f;
            Fahrenheit f = new Fahrenheit(fahrenheit);
            return f;
        }

        public static explicit operator Celsius(Kelvin k) // C = ((K * 9/5 - 459.67)-32)/(9/5)
        {
            float celcius = ((k.Cantidad * 9 / 5f - 459.67f) - 32) / (9 / 5f);
            Celsius c = new Celsius(celcius);
            return c;
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f) //(F + 459.67) * 5/9 
        {
            Kelvin kel = new Kelvin(k.Cantidad + (f.Cantidad + 459.67f) * 5 / 9f);
            return kel;
        }

        public static Kelvin operator +(Kelvin k, Celsius c)// K = (F + 459.67) * 5/9 || F = C * (9/5) + 32 
        {                                                  //  K = ((C * (9/5) + 32 ) + 459.67) * 5/9 
            Kelvin kel = new Kelvin(k.Cantidad + ((c.Cantidad * (9 / 5f) + 32) + 459.67f) * 5 / 9f);
            return kel;
        }
    }
}
