using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase18
{
    public class Comercial : Avion, IARBA
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * (25.0 / 100);
        }
    }
}
