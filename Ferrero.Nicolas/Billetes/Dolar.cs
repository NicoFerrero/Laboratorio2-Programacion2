using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private float _cotizRespectoDolar;

        private Dolar()
        {
            this._cantidad = 1;
            this._cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad):this()
        {
            this._cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion):this(cantidad)
        {
            this._cotizRespectoDolar = cotizacion;
        }

        public float GetCotizacion()
        {
            return this._cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            /*Euro e = new Euro(1);
            double cantidadDolares = d._cantidad;
            float cotizacion = e.GetCotizacion();
            e = cantidadDolares / cotizacion;*/

            Euro e = new Euro(d._cantidad / 1.3642);

            return e;
        }

        public static explicit operator Pesos(Dolar d)
        {
            /*Pesos p = new Pesos(1);
            double cantidadDolares = d._cantidad;
            float cotizacion = p.GetCotizacion();
            p = cantidadDolares * cotizacion;*/

            Pesos p = new Pesos(d._cantidad * 17.55);

            return p;
        }

        public static implicit operator Dolar(double cantidad)
        {
            Dolar d = new Dolar(cantidad);
            return d;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool rta = false;

            if(d1._cantidad == d2._cantidad)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool rta = false;

            if(d == (Dolar)e)
            {
                rta = true;
            }
            
            return rta;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool rta = false;

            if (d == (Dolar)p)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d1 = (Dolar)e;
            return d._cantidad + d1._cantidad;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            return d._cantidad + d1._cantidad;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar d1 = (Dolar)e;
            return d._cantidad - d1._cantidad;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar d1 = (Dolar)p;
            return d._cantidad - d1._cantidad;
        }

    }
}
