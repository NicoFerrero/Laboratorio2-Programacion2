using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum;
            int numero = 1;
            int cantidadPerfectos = 0;

            Console.Title = "Ejercicio Nro 04";

            while (cantidadPerfectos < 4)
            {
                acum = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acum += i;
                    }
                }

                if (numero == acum)
                {
                    Console.WriteLine("El numero {0} es perfecto", numero);
                    cantidadPerfectos++;
                }
                numero++;
            }

            Console.ReadKey();
        }
    }
}
