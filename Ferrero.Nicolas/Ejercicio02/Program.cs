using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            double cuadrado;
            double cubo;

            Console.Title = "Ejercicio Nro 02";

            Console.WriteLine("Ingrese un numero para calcularle el cuadrado y el cubo");
            numero = float.Parse(Console.ReadLine());
  
            if (numero > 0)
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
                Console.Clear();
                Console.WriteLine("El cuadrado de {0} es {1}", numero, cuadrado);
                Console.WriteLine("El cubo de {0} es {1}", numero, cubo);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            Console.ReadKey();
        }
    }
}
