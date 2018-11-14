﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1f;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        #region Conversiones
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Dolar d)
        {
            //return new Euro(d.cantidad * Euro.GetCotizacion());
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }
        #endregion

        #region Operaciones
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            // Dolar aux = d.cantidad + ((Dolar)e).GetCantidad;
            // Mi version 
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
            // ver Walter
            //return d.GetCantidad() + e.GetCantidad() / Euro.GetCotizacion();
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return aux;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        #endregion
    }
}