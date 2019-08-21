using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades.Alumnos
{
    class ExternaDerivada : PersonaExterna 
    {
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public Entidades.Externa.ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public ExternaDerivada(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo) : base(nombre, apellido, edad, sexo)
        { 
        }
    }
}
