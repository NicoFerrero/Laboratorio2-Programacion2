using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double _cantidad;
        private float _cotizRespectoDolar;

        private Pesos()
        {
            this._cantidad = 1;
            this._cotizRespectoDolar = 17.55F;
        }

        public Pesos(double cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }

        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar d = new Dolar(p._cantidad / 17.55);
            return d;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro e = new Euro(p._cantidad / 23.94171);
            return e;
        }

        public static implicit operator Pesos(double cantidad)
        {
            Pesos p = new Pesos(cantidad);
            return p;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool rta = false;

            if (p1._cantidad == p2._cantidad)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool rta = false;

            if (p == (Pesos)d)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool rta = false;

            if (p == (Pesos)e)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static Euro operator +(Pesos p, Dolar d)
        {
            Pesos p1 = (Pesos)d;

            return p._cantidad + p1._cantidad;
        }

        public static Euro operator +(Pesos p, Euro e)
        {
            Pesos p1 = (Pesos)e;

            return p._cantidad + p1._cantidad;
        }

        public static Euro operator -(Pesos p, Dolar d)
        {
            Pesos p1 = (Pesos)d;

            return p._cantidad - p1._cantidad;
        }

        public static Euro operator -(Pesos p, Euro e)
        {
            Pesos p1 = (Pesos)e;

            return p._cantidad - p1._cantidad;
        }
    }
}
