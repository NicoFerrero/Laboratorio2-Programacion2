using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades_Ejer31
{
    public class Cliente
    {
        private string _nombre;
        private int _numero;

        public string Nombre { get; set; }

        public int Numero
        {
            get
            {
                return this._numero;
            }
        }

        public Cliente(int numero)
        {
            this._numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this._nombre = nombre;
        }

        public static bool operator ==(Cliente a, Cliente b)
        {
            bool rta = false;

            if(a.Numero == b.Numero)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}
