using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) : base(precio, titulo, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return (string)this + "Tipo: " + this.tipo + "\n";
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool rta = false;

            if ((a == b) && (a.tipo == b.tipo))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public static implicit operator double(Manual m)
        {
            return m._precio;
        }
    }
}
