using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            char salir;
            int sumatoria = 0;
            bool esEntero;
            bool rta;

            Console.Title = "Ejercicio Nro 12";

            do
            {
                Console.Clear();
                Console.Write("Ingrese un numero: ");
                esEntero = int.TryParse(Console.ReadLine(), out numero);
                while(esEntero != true)
                {
                    Console.WriteLine("Error. El numero debe ser entero");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Ingrese nuevamente un numero: ");
                    esEntero = int.TryParse(Console.ReadLine(), out numero);
                }
                sumatoria += numero;
                Console.Write("¿Continuar? (S/N): ");
                salir = char.Parse(Console.ReadLine());
                rta = ValidarRespuesta.ValidaS_N(salir);

            } while (rta != false);

            Console.Clear();
            Console.WriteLine("La suma de los numeros ingresados es: {0}",sumatoria);
            Console.ReadKey();
        }
    }
}
