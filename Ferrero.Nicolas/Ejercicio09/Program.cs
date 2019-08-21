using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int asteriscos = 0;

            Console.Title = "Ejercicio Nro 09";

            Console.WriteLine("ingrese la altura de la piramide");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    asteriscos = 1;
                }
                else
                {
                    asteriscos = asteriscos + 2;
                }

                for (int j = asteriscos; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
