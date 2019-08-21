using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        private int GetIndice(Auto a)
        {
            int cantidad = this._lista.Count;
            int rta = -1;

            for (int i = 0; i < cantidad; i++)
            {
                if (this._lista[i].Equals(a) == true)
                {
                    rta = i;
                    break;
                }
            }

            return rta;
        }

        public bool Agregar(Auto a)
        {
            bool rta = false;

            if (this + a)
            {
                rta = true;
            }

            return rta;
        }

        public bool Remover(Auto a)
        {
            bool rta = false;

            if (this - a)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool rta = false;
            int cantidad = d._lista.Count;

            if (cantidad < d._capacidadMaxima)
            {
                d._lista.Add(a);
                rta = true;
            }

            return rta;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool rta = false;
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d._lista.RemoveAt(indice);
                rta = true;
            }

            return rta;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder("Capacidad de autos: " + this._capacidadMaxima + "\n" + "Listado de autos: " + "\n");
            for(int i = 0; i < this._lista.Count; i++)
            {
                cadena.Append(this._lista[i].ToString() + "\n");
            }

            return cadena.ToString();
        }
    }
}
