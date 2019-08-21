using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase09
{
    public class Auto : Vehiculo  
    {
        protected int _cantidadAsientos;

        public Auto(int cantAsientos, string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this._cantidadAsientos = cantAsientos;
        }

        public override string Acelerar()
        {
            return "El auto esta acelerado";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + "\n" + "Cantidad Asientos: " + this._cantidadAsientos + "\n";
        }

        public override bool Equals(object obj)
        {
            bool rta = false;
            if ((obj is Auto) && (((Vehiculo)obj) == this))
            {
                rta = true;
            }
            return rta;
        }

        /*public string MostrarAuto()
        {
            return base.Mostrar() + "\n" + "Cantidad Asientos: " + this._cantidadAsientos + "\n";
        }*/
    }
}
