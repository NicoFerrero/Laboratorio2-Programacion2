using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    [Serializable]
    public class Profesor : Persona
    {
        public string titulo;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }

        public Profesor() : base("sin nombre", "sin apellido", 00000000)
        {
        }

        public Profesor(string titulo, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            return base.ToString() + "-" + this.titulo;
        }
    }
}
