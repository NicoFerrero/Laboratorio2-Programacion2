﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase15
{
    public class DepositoDeStrings
    {
        private int _capacidadMaxima;
        private List<string> _lista;

        public DepositoDeStrings(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<string>();
        }

        private int GetIndice(string a)
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

        public bool Agregar(string a)
        {
            bool rta = false;

            if (this + a)
            {
                rta = true;
            }

            return rta;
        }

        public bool Remover(string a)
        {
            bool rta = false;

            if (this - a)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator +(DepositoDeStrings d, string a)
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

        public static bool operator -(DepositoDeStrings d, string a)
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
            StringBuilder cadena = new StringBuilder("Capacidad de strings: " + this._capacidadMaxima + "\n" + "Listado de strings: " + "\n");
            for (int i = 0; i < this._lista.Count; i++)
            {
                cadena.Append(this._lista[i] + "\n");
            }

            return cadena.ToString();
        }
    }
}
