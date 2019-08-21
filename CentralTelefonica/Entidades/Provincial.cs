using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : LLamada
    {
        protected Franja _franjaHoraria;


        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, LLamada unaLLamada) : this(unaLLamada.NroOrigen, miFranja, unaLLamada.Duracion, unaLLamada.NroDestino) 
        {

        }

        public Provincial(string origen, Franja miFranja,  float duracion, string destino) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costo = 0;

            if(this._franjaHoraria == Franja.Franja_1)
            {
                costo = 0.99F * this.Duracion;
            }
            else if(this._franjaHoraria == Franja.Franja_2)
            {
                costo = 1.25F * this.Duracion;
            }
            else
            {
                costo = 0.66F * this.Duracion;
            }

            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar() + "Franja Horaria: " + this._franjaHoraria + "\n" + "Costo de llamada: " + this.CostoLLamada + "\n");
            return cadena.ToString();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Provincial)
            {
                rta = true;
            }

            return rta;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
