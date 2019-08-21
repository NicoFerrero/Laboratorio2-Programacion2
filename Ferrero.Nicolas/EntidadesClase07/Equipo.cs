using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase07
{
    public class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo()
        {
            this._cantidadDeJugadores = 5;
            this._nombre = "Sin Nombre";
            this._jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this._cantidadDeJugadores = cantidad;
            this._nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool rta = true;
            int cantidad = e._jugadores.Count;

            if (cantidad == 0)
            {
                e._jugadores.Add(j);
            }
            else
            { 
                for (int i = 0; i < cantidad; i++)
                {
                    if ((e._jugadores[i] == j) || (e._cantidadDeJugadores <= cantidad))
                    {
                        rta = false;
                        break;
                    }
                }

                if (rta == true)
                {
                    e._jugadores.Add(j);
                }
            }

            return rta;
        }

        public static bool operator -(Equipo e, Jugador j)
        {
            bool rta = false;
            int cantidad = e._jugadores.Count;

            for (int i = 0; i < cantidad; i++)
            {
                if (e._jugadores[i] == j)
                {
                    e._jugadores.RemoveAt(i);
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public List<Jugador> GetJugadores()
        {
            return this._jugadores;
        }
    }
}
