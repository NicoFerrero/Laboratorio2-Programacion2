using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(DepositoHeredado))]
    public class Deposito
    {
        protected int _cantidad;
        protected Producto[] _productos;

        public Producto[] productos
        {
            get
            {
                return this._productos;
            }
            set
            {
                this._productos = value;
            }
        }

        public int cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                this._cantidad = value;
            }
        }

        public Deposito() : this(3)
        {
        }

        public Deposito(int cantidad)
        {
            this._cantidad = cantidad;
            this._productos = new Producto[0];
        }

        public static Producto[] operator +(Deposito d1, Deposito d2)
        {
            Producto[] aux = null;
            int cont = 0;

            foreach (Producto item in d1.productos)
            {
                
            }

            return aux;
        }
    }
}
