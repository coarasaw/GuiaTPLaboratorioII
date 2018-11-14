using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        private Jugador()
        {
            this._partidosJugados = 0;
            this._promedioGoles = 0;
            this._totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this._dni = dni;
            this._nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni,nombre)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }
        public float GetPromedioGoles()
        {
            return this._promedioGoles = (float)(this._totalGoles / this._partidosJugados);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre " + this._nombre);
            sb.AppendLine("DNI " + this._dni);
            sb.AppendLine("Partidos Jugados " + this._partidosJugados);
            sb.AppendLine("Promedio Goles " + GetPromedioGoles());
            sb.AppendLine("Total de Goles " + this._totalGoles);

            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1._dni == j2._dni );
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
