using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get
            {
                double rta = 0;
                for (int i = 0; i < this._libros.Count; i++)
                {
                    if (this._libros[i] is Manual)
                    {
                        rta += (double)((Manual)this._libros[i]);
                    }
                }

                return rta;
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                double rta = 0;
                for (int i = 0; i < this._libros.Count; i++)
                {
                    if (this._libros[i] is Novela)
                    {
                        rta += (double)((Novela)this._libros[i]);
                    }
                }

                return rta;
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.PrecioDeNovelas + this.PrecioDeManuales;
            }
        }

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);
            return b;
        }

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder cadena = new StringBuilder("Capacidad de biblioteca: " + e._capacidad + "\n" + "Total Manuales: " + e.PrecioDeManuales + "\n" + "Total Novelas: " + e.PrecioDeNovelas + "\n" + "Total: " + e.PrecioTotal + "\n" + "******************************************" + "\n" + "Listado de Libros" + "\n" + "******************************************" + "\n");
            for (int i = 0; i < e._libros.Count; i++)
            {
                if (e._libros[i] is Novela)
                {
                    cadena.AppendLine(((Novela)e._libros[i]).Mostrar());
                }
                else
                {
                    cadena.AppendLine(((Manual)e._libros[i]).Mostrar());
                }
            }

            return cadena.ToString();
        }

        public static bool operator ==(Biblioteca b, Libro l)
        {
            int cantidad = b._libros.Count;
            bool rta = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (b._libros[i] == l)
                {
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double rta = 0;

            switch (tipoLibro)
            {
                case ELibro.Manual:
                    rta = this.PrecioDeManuales;
                    break;

                case ELibro.Novela:
                    rta = this.PrecioDeNovelas;
                    break;

                case ELibro.Ambos:
                    rta = this.PrecioTotal;
                    break;
            }

            return rta;
        }

        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            int cantidad = b._libros.Count;
            bool esta = true;

            if (cantidad == 0)
            {
                b._libros.Add(l);
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if ((b._capacidad <= cantidad) || (b._libros[i] == l))
                    {
                        esta = false;
                        Console.WriteLine("El libro ya se encuentra en la biblioteca");
                        break;
                    }
                }

                if (esta == true)
                {
                    b._libros.Add(l);
                }
            }

            return b;
        }
    }
}
