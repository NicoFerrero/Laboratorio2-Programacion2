using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enComptenecia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this._cantidadCombustible = 0;
            this._enComptenecia = false;
            this._escuderia = escuderia;
            this._numero = numero;
            this._vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            return "Escuderia: " + this._escuderia + "\n" + "Numero: " + this._numero + "\n" + "En competencia: " + this._enComptenecia + "\n" + "Vueltas restantes: " + this._vueltasRestantes + "\n" + "Cantidad de combustible: " + this._cantidadCombustible;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool rta = false;

            if(a1._numero == a2._numero && a1._escuderia == a2._escuderia)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public void SetCombustible()
        {
            Random combustible = new Random();
            this._cantidadCombustible = Convert.ToInt16(combustible.Next(15, 100));
        }

        public void SetVueltas(short vueltas)
        {
            this._vueltasRestantes = vueltas;
        }

        public void SetEnCompetencia()
        {
            this._enComptenecia = true;
        }
    }
}
