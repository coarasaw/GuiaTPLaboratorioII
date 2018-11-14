using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }

        public Equipo( short cantidad, string nombre) :this()
        {
            this._cantidadDeJugadores = cantidad;
            this._nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool existe = false;
            foreach (Jugador item in e._jugadores)
            {
                if (item == j)
                {
                    existe = true;
                }
            }
            if (!existe  && e._jugadores.Count < e._cantidadDeJugadores)
            {
                    e._jugadores.Add(j);
                    existe = true;
            }
            else
            {
                   existe = false;
            }
            return existe;
        }
    }
}
