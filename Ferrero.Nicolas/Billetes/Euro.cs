using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double _cantidad;
        private float _cotizRespectoDolar;

        private Euro()
        {
            this._cantidad = 1;
            this._cotizRespectoDolar = 1.3642F;
        }

        public Euro(double cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }

        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            /*Dolar d = new Dolar(1);
            double cantidadEuros = e._cantidad;
            float cotizacion = e.GetCotizacion();
            d = cantidadEuros * cotizacion;*/

            Dolar d = new Dolar(e._cantidad * 1.3642);

            return d;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos p = new Pesos(e._cantidad * 23.94171);
            return p;
        }

        public static implicit operator Euro(double cantidad)
        {
            Euro e = new Euro(cantidad);
            return e;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool rta = false;

            if (e1._cantidad == e2._cantidad)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool rta = false;

            if (e == (Euro)d)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool rta = false;

            if (e == (Euro)p)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro e1 = (Euro)d;

            return e._cantidad + e1._cantidad;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro e1 = (Euro)p;

            return e._cantidad + e1._cantidad;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro e1 = (Euro)d;

            return e._cantidad - e1._cantidad;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro e1 = (Euro)p;

            return e._cantidad - e1._cantidad;
        }
    }
}
