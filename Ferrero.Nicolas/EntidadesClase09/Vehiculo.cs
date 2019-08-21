using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase09
{
    public abstract class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        public EMarcas Marca
        {
            get { return this._marca; }
        }

        public string Patente
        {
            get { return this._patente; }
        }

        public Vehiculo(string patente, byte ruedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }

        public abstract string Acelerar();

        protected virtual string Mostrar()
        {
            return "Patente: " + this._patente + "\n" + "Cant Ruedas: " + this._cantRuedas + "\n" + "Marca: " + this._marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool rta = false;

            if ((v1._patente == v2._patente) && (v1._marca == v2._marca))
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
