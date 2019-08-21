using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase06
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this._color + "-" + this._marca + "-" + this._cantidad;
        }

        public static string Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool rta = false;

            if ((t1._marca == t2._marca) && (t1._color == t2._color))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera t)
        {
            return t._cantidad;
        }

        public static explicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static Tempera operator +(Tempera t, int cantidad)
        {
            t._cantidad += cantidad;
            return t;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                t1 += t2._cantidad;
            }

            return t1;
        }
    }
}
