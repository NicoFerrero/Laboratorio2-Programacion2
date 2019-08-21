using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double _numero;

        public string SetNumero
        {
            set
            {
                this._numero = this.ValidarNumero(value);
            }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Numero():this(0)
        {
        }

        /// <summary>
        /// Constructor que recibe y carga un double
        /// </summary>
        /// <param name="numero">Valor del numero</param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        /// <summary>
        /// Constructor que recibe y carga un string
        /// </summary>
        /// <param name="strNumero">Valor del numero</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Metodo privado que se encarga de validar que se trate de un double válido, caso contrario retornará 0
        /// </summary>
        /// <param name="strNumero">Valor a validar</param>
        /// <returns>Devuelve el numero si el valor ingresado es valido o 0 si no lo es</returns>
        private double ValidarNumero(string strNumero)
        {
            bool esNumero;
            double numero;

            esNumero = double.TryParse(strNumero, out numero);
            if(esNumero != true)
            {
                numero = 0;
            }

            return numero;
        }

        /// <summary>
        /// Sobrecarga de operador + para la clase numero
        /// </summary>
        /// <param name="A">Primer operando</param>
        /// <param name="B">Segundo operando</param>
        /// <returns>Devuelve la suma de ambos numeros</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }

        /// <summary>
        /// Sobrecarga de operador - para la clase numero
        /// </summary>
        /// <param name="A">Primer operando</param>
        /// <param name="B">Segundo operando</param>
        /// <returns>Devuelve la resta de ambos numeros</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }

        /// <summary>
        /// Sobrecarga de operador * para la clase numero
        /// </summary>
        /// <param name="A">Primer operando</param>
        /// <param name="B">Segundo operando</param>
        /// <returns>Devuelve la multiplicacion de ambos numeros</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }

        /// <summary>
        /// Sobrecarga de operador / para la clase numero
        /// </summary>
        /// <param name="A">Primer operando</param>
        /// <param name="B">Segundo operando</param>
        /// <returns>Devuelve la division de ambos numeros o en caso de que el segundo operando sea 0 devuelve 0</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado = 0;

            if(n2._numero != 0)
            {
                resultado = n1._numero - n2._numero;
            }

            return resultado;
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero a ser convertido</param>
        /// <returns>Devuelve un numero binario en formato string, o "Valor invalido" en caso de no poder realizar la conversion</returns>
        public static string DecimalBinario(string numero)
        {
            int resultado;
            string rta;
            bool sePuede = int.TryParse(numero, out resultado);
            if (sePuede == true)
            {
                rta = Convert.ToString(resultado, 2);
            }
            else
            {
                rta = "Valor invalido";
            }

            return rta;
        }

        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero a ser convertido</param>
        /// <returns>Devuelve un numero binario en formato string, o "Valor invalido" en caso de no poder realizar la conversion</returns>
        public static string DecimalBinario(double numero)
        {
            string rta;
            rta = Numero.DecimalBinario(numero.ToString());
            return rta;
        }

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario">Numero a ser convertido</param>
        /// <returns>Devuelve un numero decimal en formato string, o "Valor invalido" en caso de no poder realizar la conversion</returns>
        public static string BinarioDecimal(string binario)
        {
            int resultado;
            string rta;
            bool sePuede = int.TryParse(binario, out resultado);
            if(sePuede == true)
            {
                rta = Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                rta = "Valor invalido";
            }
            
            return rta;
        }
    }
}
