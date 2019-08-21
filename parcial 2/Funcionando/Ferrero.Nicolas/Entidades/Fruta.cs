using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Platano))]
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public virtual bool TieneCarozo
        {
            get
            {
                return true;
            }
            set
            { 
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public float Peso
        {
            get
            {
                return this._peso;
            }
            set
            {
                this._peso = value;
            }
        }

        public Fruta()
        {
        }

        public Fruta(float peso, ConsoleColor color)
        {
            this._peso = peso;
            this._color = color;
        }

        protected virtual string FrutaToString()
        {
            return string.Format("Peso: {0} | Color: {1}", this._peso, this._color);
        }
    }
}
