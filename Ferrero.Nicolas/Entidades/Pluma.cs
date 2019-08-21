using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 0;
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta):this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad):this(marca, tinta)
        {
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this._marca + "-" + "- " + Tinta.Mostrar(this._tinta) + "-" + "-" + this._cantidad;
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            bool rta;

            if (pluma._tinta == tinta)
            {
                rta = true;
            }
            else
            {
                rta = false;
            }

            return rta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma._cantidad < 100)
            {
                pluma._cantidad++;
            }

            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma._cantidad > 0)
            {
                pluma._cantidad--;
            }

            return pluma;
        }
    }
}
