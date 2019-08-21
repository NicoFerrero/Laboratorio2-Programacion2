using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase09
{
    public class Moto : Vehiculo  
    {
        protected float _cilindrada;

        public Moto(float cilindrada, string patente, byte ruedas, EMarcas marca) : base(patente, ruedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + "\n" + "Cilindrada: " + this._cilindrada + "\n";
        }

        public override bool Equals(object obj)
        {
            bool rta = false;
            if ((obj is Moto) && (((Vehiculo)obj) == this))
            {
                rta = true;
            }
            return rta;
        }

        public override string Acelerar()
        {
            return "La moto esta acelerada";
        }

        /*public string MostrarMoto()
        {
            return base.Mostrar() + "\n" + "Cilindrada: " + this._cilindrada + "\n";
        }*/
    }
}
