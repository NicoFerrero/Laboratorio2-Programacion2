using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesClase20
{
    [Serializable]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _dni;

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

        public Persona()
        {
 
        }

        public Persona(string nombre, string apellido, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
        }

        public override string ToString()
        {
            return this._nombre + "-" + this._apellido + "-" + this._dni;
        }
    }
}
