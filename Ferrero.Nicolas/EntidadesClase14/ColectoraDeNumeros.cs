using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14
{
    public class ColectoraDeNumeros
    {
        private List<Numero> _numeros;

        public ETipoNumero Tipo { get; set; }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipo) : this()
        {
            this.Tipo = tipo;
        }

        public static bool operator ==(ColectoraDeNumeros c, Numero n)
        {
            bool rta = false;
            int cantidad = c._numeros.Count;

            for (int i = 0; i < cantidad; i++)
            {
                if (c._numeros[i].MiNumero == n.MiNumero)
                {
                    rta = true;
                }
            }

            return rta;
        }

        public static bool operator !=(ColectoraDeNumeros c, Numero n)
        {
            return !(c == n);
        }

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros c, Numero n)
        {
            if (Verificadora.VerificarNumero(c.Tipo, n))
            {
                c._numeros.Add(n);
            }
            else
            {
                throw new Exception("La contenedora admite datos del tipo " + c.Tipo);
            }

            return c;
        }

        public static ColectoraDeNumeros operator -(ColectoraDeNumeros c, Numero n)
        {
            if (c == n)
            {
                c._numeros.Remove(n);
            }
            else
            {
                throw new Exception("No existe el numero que desea remover" + "\n" + c.ToString());
            }

            return c;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder("La clase es del tipo " + this.Tipo + "\n" + "Sus elementos son: ");
            for(int i = 0; i < this._numeros.Count; i++)
            {
                cadena.Append(this._numeros[i].MiNumero + "  ");
            }

            return cadena.ToString();
        }
    }
}
