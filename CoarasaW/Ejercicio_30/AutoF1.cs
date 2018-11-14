using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        private AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                  this.enCompetencia = value;
            }
        }
        public short VueltaRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ------------- AUTO -----------------");
            sb.AppendLine("Cantidad de Combustible " + cantidadCombustible);
            sb.AppendLine("En Competencia " + enCompetencia.ToString());
            sb.AppendLine("Escuderia " + escuderia);
            sb.AppendLine("Numero " + numero);
            sb.AppendLine("Vueltas Restantes " + vueltasRestantes);
            sb.AppendLine(" -------------------------------------");

            return sb.ToString();
        }
    }
}
