using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esEntero;
            int max = 0;
            int min = 0;
            int sumatoria = 0;
            float prom = 0;
            bool rta;

            Console.Title = "Ejercicio Nro 11";

            for (int i = 0; i < 10; i++)
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
                rta = Validacion.Validar(numero, -100, 100);
                while(rta != true)
                {
                    Console.WriteLine("Error. Numero fuera del rango -100 a 100");
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write("Ingrese nuevamente un numero: ");
                    esEntero = int.TryParse(Console.ReadLine(), out numero);
                    while (esEntero != true)
                    {
                        Console.WriteLine("Error. El numero debe ser entero");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ingrese nuevamente un numero: ");
                        esEntero = int.TryParse(Console.ReadLine(), out numero);
                    }
                    rta = Validacion.Validar(numero, -100, 100);
                }
                if(i == 0)
                {
                    max = numero;
                    min = numero;
                }
                if(numero < min)
                {
                    min = numero;
                }
                if (numero > max)
                {
                    max = numero;
                }
                sumatoria += numero;
            }

            prom = sumatoria / 10;
            Console.Clear();
            Console.WriteLine("El valor minimo es {0} el valor maximo es {1} y el promedio de los valores es {2:#,###.00}", min, max, prom);
            Console.ReadKey();
        }
    }
}
