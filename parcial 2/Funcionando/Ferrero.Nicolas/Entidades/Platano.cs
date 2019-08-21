using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Platano : Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
            set
            {

            }
        }

        public string Tipo
        {
            get
            {
                return "Platano";
            }
            set
            {

            }
        }

        public Platano() : base()
        {
        }

        public Platano(float peso, ConsoleColor color, string pais) : base(peso, color)
        {
            this.paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + string.Format(" | Tipo fruta: {0} | Carozo: {1} | Origen: {2}", this.Tipo, this.TieneCarozo, this.paisOrigen);
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
