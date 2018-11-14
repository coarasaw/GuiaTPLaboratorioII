using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43 
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get {return this.nombreClase;}
        }

        public string NombreMetodo
        {
            get {return this.nombreMetodo; }
        }

        public CompetenciaNoDisponibleException(string mensaje,string clase,string metodo):base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException):base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Metodo " + NombreMetodo);
            datos.AppendLine("Clase  " + NombreClase);
            datos.AppendLine(base.Message);
            //datos.AppendLine(base.InnerException.Message);
            return datos.ToString();
        }
    }
}
