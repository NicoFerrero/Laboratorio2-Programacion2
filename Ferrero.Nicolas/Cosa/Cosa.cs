using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadCosa
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Cosa():this(10,"Sin valor", DateTime.Now)
        {
            /*this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;*/
        }

        /// <summary>
        /// Constructor parametrizado de 2 parametros
        /// </summary>
        /// <param name="entero">Es el valor que tendra el atributo entero de la clase</param>
        /// <param name="cadena">Es el valor que tendra el atributo string de la clase</param>
        public Cosa(int entero, string cadena)
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = DateTime.Now;
        }
        
        /// <summary>
        /// Constructor parametrizado de 1 parametros
        /// </summary>
        /// <param name="entero">Es el valor que tendra el atributo entero de la clase</param>
        public Cosa(int entero)
        {
            this.entero = entero;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        /// <summary>
        /// Constructor parametrizado de 3 parametros
        /// </summary>
        /// <param name="entero">Es el valor que tendra el atributo entero de la clase</param>
        /// <param name="cadena">Es el valor que tendra el atributo string de la clase</param>
        /// <param name="fecha">Es el valor que tendra el atributo DateTime de la clase</param>
        public Cosa(int entero, string cadena, DateTime fecha)
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = fecha;
        }

        /// <summary>
        /// Establecer un valor para un atributo de clase
        /// </summary>
        /// <param name="entero">Entero establecera un valor entero para nuestra clase</param>
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        /// <summary>
        /// Establecer un valor para un atributo de clase
        /// </summary>
        /// <param name="cadena">Cadena establecera un valor string para nuestra clase</param>
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        /// <summary>
        /// Establecer un valor para un atributo de clase
        /// </summary>
        /// <param name="fecha">Fecha establecera un valor DateTime para nuestra clase</param>
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        /// <summary>
        /// Muestra los valores de los atributos de clase
        /// </summary>
        /// <returns>Devuelve un string con los datos de los atributos de clase</returns>
        public string Mostrar()
        {
            /*string cadena;
            cadena = "Entero: " + this.entero + "\nCadena:  " + this.cadena + "\nFecha: " + this.fecha;
            return cadena;*/

            return "Entero: " + this.entero + "\nCadena:  " + this.cadena + "\nFecha: " + this.fecha;
        }
    }
}
