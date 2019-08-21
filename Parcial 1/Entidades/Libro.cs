using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas
        {
            get
            {
                if (this._cantidadDePaginas == 0)
                {
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10, 580);
                }
                return this._cantidadDePaginas;
            }
        }

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            this._titulo = titulo;
            this._autor = new Autor(nombre, apellido);
            this._precio = precio;
            this._cantidadDePaginas = this.CantidadDePaginas;
        }

        public Libro(string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._precio = precio;
            this._cantidadDePaginas = this.CantidadDePaginas;
        }

        private static string Mostrar(Libro l)
        {
            return "Titulo: " + l._titulo + "\n" + "Autor: " + ((string)l._autor) + "\n" + "Precio: " + l._precio + "\n" + "Paginas: " + l.CantidadDePaginas + "\n";
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool rta = false;

            if ((a._autor == b._autor) && (string.Compare(a._titulo, b._titulo) == 0))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
    }
}
