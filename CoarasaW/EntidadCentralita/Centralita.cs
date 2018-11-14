using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadCentralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0, gananciaLoc = 0, gananciaProv = 0;
            foreach (Llamada item in listaDeLlamadas)
            {
                if (tipo == TipoLlamada.Local && item is Local)
                {
                    ganancia += ((Local)item).CostoLlamada;

                }
                if (tipo == TipoLlamada.Provincial && item is Provincial)
                {
                    ganancia += ((Provincial)item).CostoLlamada;
                }
                if (tipo == TipoLlamada.Todas)
                {
                    if (item is Local)
                    {
                        gananciaLoc += ((Local)item).CostoLlamada;
                    }
                    if (item is Provincial)
                    {
                        gananciaProv += ((Provincial)item).CostoLlamada;
                    }
                    ganancia = gananciaLoc + gananciaProv;
                }
            }
            return ganancia;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social: " + this.razonSocial.ToString());
            sb.AppendLine("Ganancia Total: " + this.GananciaTotal.ToString());
            sb.AppendLine("Ganancia por llamadas locales: " + this.GananciaPorLocal.ToString());
            sb.AppendLine("Ganancia por llamadas provinciales: " + this.GananciaPorProvincial.ToString());
            foreach (Llamada item in this.listaDeLlamadas)
                sb.AppendLine(item.ToString());
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            Console.WriteLine("**********Llamadas Ordenadas por Duracion***********");
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada unaLlamada)
        {
            this.listaDeLlamadas.Add(unaLlamada);
        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            for (int i = 0; i < central.listaDeLlamadas.Count; i++)
                if (central.listaDeLlamadas[i] == nuevaLlamada)
                    return true;
            return false;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (!(central == nuevaLlamada))
                central.AgregarLlamada(nuevaLlamada);
            else
                Console.WriteLine("Error, La llamada ya esta Registrada");
            return central;
        }
    }
}
