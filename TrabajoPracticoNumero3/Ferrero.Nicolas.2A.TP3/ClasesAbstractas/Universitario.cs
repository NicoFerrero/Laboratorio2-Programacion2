using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    /// <summary>
    /// . Abstracta, con el atributo Legajo.
    /// . Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
    /// . Método protegido y abstracto ParticiparEnClase.
    /// . Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
    /// </summary>
    public abstract class Universitario : Persona
    {
        protected int legajo;

        /// <summary>
        /// Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales
        /// </summary>
        /// <param name="obj">Elemento a comparar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;

            if(this == ((Universitario)obj))
            {
                rta = true;
            }

            return rta;
        }

        /// <summary>
        /// Retornará todos los datos del Universitario.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine(base.ToString());
            cadena.AppendLine("LEGAJO NUMERO: " + this.legajo);
            cadena.AppendLine("");

            return cadena.ToString();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool rta = false;

            if((pg1 is Universitario && pg2 is Universitario) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI))
            {
                rta = true;
            }

            return rta; ;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticiparEnClase();

        public Universitario() : base()
        {
        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

    }
}
