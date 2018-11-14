using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }

            set
            {
                this.cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia):base(numero,escuderia)
        { }

        public MotoCross(short numero,string escuderia,short cilindrada)
            :this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.Mostrar());
            datos.AppendLine("Cilindrada " + Cilindrada);
            return datos.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return ((VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && (a1.Cilindrada == a2.Cilindrada));
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
