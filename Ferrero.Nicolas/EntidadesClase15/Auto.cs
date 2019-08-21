using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool rta = false;

            if((string.Compare(a.Color, b.Color) == 0) && (string.Compare(a.Marca, b.Marca) == 0))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if ((obj is Auto) && (this == (Auto)obj))
            {
                rta = true;
            }

            return rta;
        }

        public override string ToString()
        {
            return "Color: " + this.Color + " Marca: " + this.Marca;
        }
    }
}
