using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase06
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantidadMaximaColores;

        private Paleta():this(5)
        {
        }

        private Paleta(int cantidad)
        {
            this._cantidadMaximaColores = cantidad;
            this._colores = new Tempera[this._cantidadMaximaColores];
        }

        public static implicit operator Paleta(int cantidad)
        {
            Paleta p = new Paleta(cantidad);

            return p;
        }

        private string Mostrar()
        {
            string colores = "";
            colores += "La cantidad de colores es: " + this._cantidadMaximaColores + "\n";
            foreach (Tempera t in this._colores)
            {
                if (((object)t) != null)
                {
                    colores += Tempera.Mostrar(t) + "\n";
                }
            }

            //for (int i = 0; i < this._cantidadMaximaColores; i++)
            //{
            //    if (this._colores.GetValue(i) != null)
            //    { 
            //        colores += Tempera.Mostrar(this._colores[i]) + "\n";
            //    }
            //}
            return colores;
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool rta = false;

            foreach (Tempera tempera in p._colores)
            {
                if (((object)tempera) == t)
                {
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            int index;

            if (p == t)
            {
                t += 1;
            }
            else
            {
                index = p.ObtenerIndice();
                if (index != -1)
                {
                    p._colores[index] = t;
                }
            }

            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            int index;
            int cantidadTempera;

            index = p.ObtenerIndice(t);
            if (index != -1)
            {
                t += -1; 
                cantidadTempera = t;
                if (cantidadTempera <= 0)
                {
                    p._colores[index] = null;
                }
            }

            return p;
        }

        private int ObtenerIndice()
        {
            int rta = -1;
 
            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if (this._colores.GetValue(i) == null)
                {
                    rta = i;
                    break;
                }
            }

            return rta;
        }

        private int ObtenerIndice(Tempera t)
        {
            int rta = -1;

            for (int i = 0; i < this._cantidadMaximaColores; i++)
            {
                if (this._colores[i] == t)
                {
                    rta = i;
                }
            }

            return rta;
        }


    }
}
