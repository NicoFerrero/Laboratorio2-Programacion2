using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    public class Persona
    {
        private int _id;
        private string _nombre;
        private string _apellido;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public Persona(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            this._id = id;
        }

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public override string ToString()
        {
            return "ID: " + this.Id + " Nombre: " + this.Nombre + " Apellido: " + this.Apellido;
        }
    }
}
