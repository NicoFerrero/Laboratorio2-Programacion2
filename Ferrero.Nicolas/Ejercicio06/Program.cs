using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;

            Console.Title = "Ejercicio Nro 06";

            Console.WriteLine("Ingrese un año para saber si es bisiesto o no");
            anio = int.Parse(Console.ReadLine());

            if ((anio % 4 == 0) || (anio % 100 == 0 && anio % 400 == 0))
            {
                Console.Clear();
                Console.WriteLine("El año {0} es bisiesto", anio);
            }

            Console.ReadKey();
        }
    }
}
