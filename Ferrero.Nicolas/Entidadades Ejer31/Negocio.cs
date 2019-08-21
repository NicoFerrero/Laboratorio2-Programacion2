using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadades_Ejer31
{
    public class Negocio
    {
        private PuestoAtencion _caja;
        private Queue<Cliente> _clientes;
        private string _nombre;

        public Cliente Clientes
        {
            get
            {
                return this._clientes.Dequeue();
            }

            set
            {
                bool rta = false;

                foreach(Cliente c in this._clientes)
                {
                    if(c == value)
                    {
                        rta = true;
                    }
                }

                if(rta == false)
                {
                    this._clientes.Enqueue(value);
                }
            }
        }

        private Negocio()
        {
            this._clientes = new Queue<Cliente>();
            this._caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool rta = false;

            foreach(Cliente caux in n._clientes)
            {
                if(caux == c)
                {
                    rta = true;
                }
            }

            return rta;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool rta = false;

            if(n != c)
            {
                n.Clientes = c;
                rta = true;
            }

            return rta;
        }
    }
}
