using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase20
{
    [Serializable]
    public class Alumno : Persona
    {
        public int legajo;


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

        public Alumno() : base("sin nombre", "sin apellido", 00000000)
        {
        }
        
        public Alumno(int legajo, string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        { 
            this.legajo = legajo;
        }

        public override string ToString()
        {
            return base.ToString() + "-" + this.legajo;
        }
    }
}
