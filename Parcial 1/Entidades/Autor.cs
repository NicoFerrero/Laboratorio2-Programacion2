using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string _apellido;
        private string _nombre;

        public Autor(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool rta = false;

            if ((string.Compare(a._nombre, b._nombre) == 0) && (string.Compare(a._apellido, b._apellido) == 0))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

        public static implicit operator string(Autor a)
        {
            return string.Format("{0} {1}", a._nombre, a._apellido);
        }
    }
}
