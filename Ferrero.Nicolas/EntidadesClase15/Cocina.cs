using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool rta = false;

            if (a.Codigo == b.Codigo)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if ((obj is Cocina) && (this == (Cocina)obj))
            {
                rta = true;
            }

            return rta;
        }

        public override string ToString()
        {
            string cadena = "";

            if(this.EsIndustrial == true)
            {
                cadena = "Codigo: " + this.Codigo + " Precio: " + this.Precio + " Es industrial: si";
            }
            else
            {
                cadena = "Codigo: " + this.Codigo + " Precio: " + this.Precio + " Es industrial: no";
            }

            return cadena;
        }
    }
}
