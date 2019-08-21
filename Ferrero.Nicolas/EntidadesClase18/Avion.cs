using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase18
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio del avion es " + this._precio);
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * (27.0 / 100);
        }

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * (33.0 / 100);
        }
    }
}
