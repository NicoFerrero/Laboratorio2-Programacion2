using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta()
        {
            this._color = ConsoleColor.Black;
            this._tipoTinta = ETipoTinta.comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tinta):this(color)
        {
            this._tipoTinta = tinta;
        }

        private string Mostrar()
        {
            return this._color + "-" + this._tipoTinta;
        }

        public static string Mostrar(Tinta tinta)
        {
            //return tinta._color + "-" + tinta._tipoTinta;
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            bool rta;

            if ((tinta1._color == tinta2._color) && (tinta1._tipoTinta == tinta2._tipoTinta))
            {
                rta = true;
            }
            else
            {
                rta = false;
            }

            return rta;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }
    }
}
