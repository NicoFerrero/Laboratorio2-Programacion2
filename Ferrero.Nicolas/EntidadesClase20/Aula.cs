using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    [Serializable]
    public class Aula
    {
        private int _numero;
        private List<Persona> _lista;

        public int Numero 
        { 
            get
            {
                return this._numero;
            }
            set
            {
                this._numero = value;
            }
        }

        public List<Persona> Lista
        {
            get
            {
                return this._lista;
            }
        }

        public Aula()
        {
            this._lista = new List<Persona>();
        }

        public Aula(int numero) : this()
        {
            this._numero = numero;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            for (int i = 0; i < this._lista.Count; i++)
            {
                cadena.AppendLine(this._lista[i].ToString());
            }

            return cadena.ToString();
        }


    }
}
