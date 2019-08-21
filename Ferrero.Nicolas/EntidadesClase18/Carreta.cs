using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase18
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio) : base(precio)
        {
        }

        public double CalcularImpuesto()
        {
            return this._precio * (18.0 / 100);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("El precio de la carreta es " + this._precio);
        }
    }
}
