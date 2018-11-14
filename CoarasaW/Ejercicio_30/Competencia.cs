using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidodes;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas,short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidodes = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de Comperidores " + this.cantidadCompetidodes);
            sb.AppendLine("Cantidad de Vueltas      " + this.cantidadVueltas);
            sb.AppendLine("--------------------------");
            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool esta = false;
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(!(c==a) && c.competidores.Count <= c.cantidadCompetidodes)
            {
                a.EnCompetencia = true;
                //poner ramdom al combustible
                Random calc = new Random();
                a.CantidadCombustible = (short)calc.Next(15,100);
                Thread.Sleep(150);
                a.VueltaRestantes = c.cantidadVueltas;
                c.competidores.Add(a);
                return true;    
            }
            return false;
        }
    }
}
