using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalLineas = 0;
            int nLineas = 0;
            int nast = 0;
            int nesp = 0;

            Console.Title = "Ejercicio Nro 10";

            Console.WriteLine("Ingrese cantidad de lineas");
            totalLineas = int.Parse(Console.ReadLine());

            while(nLineas <= totalLineas)
            {
                while(nesp < totalLineas - nLineas)
                {
                    Console.Write(" ");
                    nesp++;
                }
                while(nast < ((nLineas * 2) - 1))
                {
                    Console.Write("*");
                    nast++;
                }
                nesp = 0;
                nast = 0;
                nLineas++;
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
