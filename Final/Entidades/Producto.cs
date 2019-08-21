using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string _nombre;
        private int _stock;

        public string nombre
        {
            get
            {
                return this._nombre;
            }
            set
            { 
            }
        }

        public int stock
        {
            get
            {
                return this._stock;
            }
            set
            { 
            }
        }

        public Producto(string nombre, int stock)
        {
            this._nombre = nombre;
            this._stock = stock;
        }
    }
}
