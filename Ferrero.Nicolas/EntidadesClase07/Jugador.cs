using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase07
{
    public class Jugador
    {
        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioDeGoles;
        private int _totalGoles;

        public long Dni
        {
            get { return this._dni; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int PartidosJugados
        {
            get { return this._partidosJugados; }
            set { this._partidosJugados = value; }
        }

        public int TotalGoles
        {
            get { return this._totalGoles; }
            set { this._totalGoles = value; }
        }

        private Jugador(): this("Sin Nombre", 1, 0, 0)
        {
        }

        public Jugador(string nombre, long dni)
        {
            this._nombre = nombre;
            this._dni = dni;
        }

        public Jugador(string nombre, long dni, int totalGoles, int totalPartidos):this(nombre, dni)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            return this._promedioDeGoles = (float)this._totalGoles / this._partidosJugados;
        }

        public string MostrarDatos()
        {
            return "Nombre: " + this._nombre + "\n" + " Dni: " + this._dni + "\n" + " Partidos Jugados: " + this._partidosJugados + "\n" + " Goles: " + this._totalGoles + "\n" + " Promedio goles: " + this.GetPromedioGoles(); 
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool rta = false;

            if (j1._dni == j2._dni)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}