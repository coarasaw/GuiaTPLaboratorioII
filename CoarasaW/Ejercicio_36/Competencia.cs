using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get {return this.cantidadCompetidores; }
            set {this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get {return this.cantidadVueltas; }
            set {this.cantidadVueltas = value ; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get {return this.tipo; }
            set {this.tipo = value; }
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas,short cantCompetidores,TipoCompetencia tipo)
        {
            this.cantidadVueltas = cantVueltas;
            this.cantidadCompetidores = cantCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Cantidad Competidores " + CantidadCompetidores);
            datos.AppendLine("Cantidad de Vueltas " + CantidadVueltas);
            datos.AppendLine("Tipo " + Tipo);
            foreach (VehiculoDeCarrera competidor in competidores)
            {
                datos.AppendLine(competidor.Mostrar());
            }
            return datos.ToString();
        }

        public static bool operator ==(Competencia c,VehiculoDeCarrera a)
        {
            bool agregar = false;
            if (c.Tipo == TipoCompetencia.MotoCross)
            {
                agregar = true;
            }
            if (c.Tipo == TipoCompetencia.F1)
            {
                agregar = true;
            }

            return agregar;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c,VehiculoDeCarrera a)
        {
            bool seAgrego = false;
            if (c==a)
            {
                c.competidores.Add(a);
                seAgrego = true;
            }
            return seAgrego;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool seAgrego = false;
            if (c == a)
            {
                c.competidores.Remove(a);
                seAgrego = true;
            }
            return seAgrego;
        }
    }

    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
}
