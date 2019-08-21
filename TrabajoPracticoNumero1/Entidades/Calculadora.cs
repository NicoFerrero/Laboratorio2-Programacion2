using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Metodo que valida el operador
        /// </summary>
        /// <param name="operador">Operador aritmetico</param>
        /// <returns>Devuelve el operador o en caso de que no sea valido devuelve "+"</returns>
        private static string ValidarOperador(string operador)
        {
            string rta = "+";

            if(operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                rta = operador;
            }

            return rta;
        }

        /// <summary>
        /// Metodo que se encarga de realizar las operaciones. Su valor de retorno será del tipo double. Si no puede operar retornará 0.
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operador aritmetico</param>
        /// <returns>Devuelve el resultado de la operacion deseada</returns>
        public double Operar(Numero num1, Numero num2, string operador)
        {
            string operacion = Calculadora.ValidarOperador(operador);
            double resultado = 0;

            switch(operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
    }
}
