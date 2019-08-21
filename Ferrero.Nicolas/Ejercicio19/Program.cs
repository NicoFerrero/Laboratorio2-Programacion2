using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";

            Sumador suma = new Sumador(5);
            Sumador suma1 = new Sumador(5);

            long resultado = suma.Sumar(3, 4);

            Console.WriteLine("Resultado: {0}", resultado);

            Console.WriteLine("Cantidad de sumas: {0}", (int)suma);

            Console.WriteLine();

            string resultado1 = suma1.Sumar("Hola", "Mundo");

            Console.WriteLine("Resultado: " + resultado1);

            Console.WriteLine("Cantidad de sumas: {0}", (int)suma1);

            Console.WriteLine();

            long resultado2 = suma + suma1;

            Console.WriteLine("La suma de ambas cantidades de sumas es: {0}", resultado2);

            Console.WriteLine();

            bool resultado3 = suma | suma1;

            Console.WriteLine("Las cantidades de sumas son iguales?: {0}", resultado3);

            Console.ReadKey();
        }
    }
}
