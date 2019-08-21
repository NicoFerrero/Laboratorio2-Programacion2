using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero) : base(titulo,autor,precio) 
        {
            this.genero = genero;
        }

        public string Mostrar()
        {
            return (string)this + "Genero: " + this.genero + "\n";
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool rta = false;

            if ((a == b) && (a.genero == b.genero))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }

        public static implicit operator double(Novela m)
        {
            return m._precio;
        }
    }
}
