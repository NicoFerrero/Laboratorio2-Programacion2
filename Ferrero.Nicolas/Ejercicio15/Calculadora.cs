using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char op)
        {
            double resultado = 0;
            bool esDistinto;

            switch(op)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;

                case '-':
                    resultado = numero1 - numero2;
                    break;

                case '*':
                    resultado = numero1 * numero2;
                    break;

                case '/':
                    esDistinto = Validar(numero2);
                    if(esDistinto != true)
                    {
                        Console.Clear();
                        Console.WriteLine("Error. El divisor debe ser distinto de cero");
                        Console.ReadKey();
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                    }
                    break;

                default:
                    break;

            }



            return resultado;
        }

        private static bool Validar(double divisor)
        {
            bool rta = true;

            if(divisor == 0)
            {
                rta = false;
            }

            return rta;
        }

        public static void Mostrar(double resultado)
        {
            Console.Clear();
            Console.Write("El resultado de la operacion es {0:#,###.00}", resultado);
            Console.ReadKey();
        }
    }
}
