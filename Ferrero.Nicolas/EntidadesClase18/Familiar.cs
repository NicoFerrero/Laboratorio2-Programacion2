using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase18
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantAsientos) : base(precio, patente)
        {
            this._cantAsientos = cantAsientos;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("La patente del auto es " + this._patente);
        }
    }
}
