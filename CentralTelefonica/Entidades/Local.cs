using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : LLamada
    {
        protected float _costo;

        public override float CostoLLamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(LLamada unaLLamada, float costo) : this(unaLLamada.NroOrigen, unaLLamada.Duracion, unaLLamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return this._costo * this.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder(base.Mostrar() + "Costo de llamada: " + this.CostoLLamada + "\n");
            return cadena.ToString();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if(obj is Local)
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
