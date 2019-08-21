using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";

            Console.WriteLine("1.3642 dolar es igual a 1 euros?");
            Dolar d = new Dolar(1.3642);
            Euro e = new Euro(1);

            if (d == e)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.WriteLine();

            Console.WriteLine("1 dolar es igual a 17.55 pesos?");
            Dolar d1 = new Dolar(1);
            Pesos p = new Pesos(17.55);

            if (d1 == p)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.WriteLine();

            Console.WriteLine("1 euro es igual a 23,94171 pesos?");
            Euro e1 = new Euro(1);
            Pesos p1 = new Pesos(23.94171);

            if (p1 == e1)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.WriteLine();

            Console.WriteLine("1.3642 dolar + 1 euro son iguales a 2.7284 dolares?");
            Dolar d2 = new Dolar(2.7284);
            d += e;

            if(d == d2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.WriteLine();

            Console.WriteLine("1 dolar + 17,55 pesos son iguales a 2 dolares?");
            Dolar d3 = new Dolar(2);
            d1 += p;

            if (d1 == d3)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }

            Console.ReadKey();

        }
    }
}
