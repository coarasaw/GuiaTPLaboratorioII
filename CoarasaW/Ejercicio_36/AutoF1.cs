using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballoDeFuerza;

        public short CaballoDeFuerza
        {
            get {return this.caballoDeFuerza; }
            set {this.caballoDeFuerza = value; }
        }

        public AutoF1(short numero, string escuderia) :base(numero,escuderia)
        { }

        public AutoF1(short numero, string escuderia,short caballoDeFuerza):this(numero,escuderia)
        {
            this.caballoDeFuerza = caballoDeFuerza;
        }

       
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((VehiculoDeCarrera)a1==(VehiculoDeCarrera)a2 && (a1.CaballoDeFuerza == a2.CaballoDeFuerza));
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string Mostrar()
        {
            StringBuilder dato = new StringBuilder();
            dato.AppendLine(base.Mostrar());
            dato.AppendLine("AutoF1");
            dato.AppendLine("Caballos de Fuerza " + CaballoDeFuerza);
            return dato.ToString();
        }
    }
}
