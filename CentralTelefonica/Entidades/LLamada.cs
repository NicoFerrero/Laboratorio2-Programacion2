using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class LLamada
    {
        protected float _duracion;
        protected string _nroOrigen;
        protected string _nroDestino;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public abstract float CostoLLamada
        {
            get;
        }

        public LLamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder("Duracion: " + this._duracion + "\n" + "Origen: " + this._nroOrigen + "\n" + "Destino: " + this._nroDestino + "\n");
            return cadena.ToString();
        }

        public static int OrdenarPorDuracion(LLamada l1, LLamada l2)
        {
            int rta = 0;

            if (l1.Duracion > l2.Duracion)
                rta = 1;

            if (l1.Duracion < l2.Duracion)
                rta = -1;

            return rta;
        }

        public static bool operator ==(LLamada l1, LLamada l2)
        {
            bool rta = false;

            if(l1 is Local && l2 is Local)
            {
                if(l1.NroOrigen.Equals(l2.NroOrigen) == true && l1.NroDestino.Equals(l2.NroDestino) == true)
                {
                    rta = true;
                }
            }

            if (l1 is Provincial && l2 is Provincial)
            {
                if (l1.NroOrigen.Equals(l2.NroOrigen) == true && l1.NroDestino.Equals(l2.NroDestino) == true)
                {
                    rta = true;
                }
            }

            return rta;
        }

        public static bool operator !=(LLamada l1, LLamada l2)
        {
            return !(l1 == l2);
        }
    }
}
