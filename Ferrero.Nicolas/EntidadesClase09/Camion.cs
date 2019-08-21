using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase09
{
    public class Camion : Vehiculo  
    {
        protected float _tara;

        public Camion(float tara, string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + "\n" + "Tara: " + this._tara + "\n";
        }

        public override string Acelerar()
        {
            return "El camion esta acelerado";
        }

        public override bool Equals(object obj)
        {
            bool rta = false;
            if ((obj is Camion) && (((Vehiculo)obj) == this))
            {
                rta = true;
            }
            return rta;
        }

        /*public string MostrarCamion()
        {
            return base.Mostrar() + "\n" + "Tara: " + this._tara + "\n";
        }*/
    }
}
