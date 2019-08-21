using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void Delegado(object sender, EventArgs e);

    public class Galpon<T>
    {
        private List<T> _elementos;
        private int _capacidad;
        public event Delegado ElementosParesEvent;

        private Galpon()
        {
            this._elementos = new List<T>();
        }

        public Galpon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public void Add(T b)
        {
            if (this._capacidad > this._elementos.Count)
            {
                this._elementos.Add(b);
                if(b is Producto)
                    this.ElementosParesEvent(this, new EventArgs());
                /*if (b is Producto)
                {
                    if(((Producto)b).stock % 2 == 0)
                    this.ElementosParesEvent(this, new EventArgs());
                }*/
            }
        }
    }
}
