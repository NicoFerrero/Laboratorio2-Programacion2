using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace EjerClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta = new Tinta();
            Tinta tinta1 = new Tinta(ConsoleColor.Blue);
            Tinta tinta2 = new Tinta(ConsoleColor.Red, ETipoTinta.china);
            Tinta tinta3 = new Tinta(ConsoleColor.Black);

            Pluma pluma = new Pluma();
            Pluma pluma1 = new Pluma("Stadler");
            Pluma pluma2 = new Pluma("Liquid Paper", tinta2, 50);
            Pluma pluma3 = new Pluma("Faber Castel", tinta1);


            Console.WriteLine("Tintas");
            Console.WriteLine(Tinta.Mostrar(tinta));
            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));

            Console.WriteLine();

            Console.WriteLine("tinta es igual a tinta 1?");
            if (tinta == tinta1)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintas");
            }

            Console.WriteLine();

            Console.WriteLine("tinta es igual a tinta 3?");
            if (tinta == tinta3)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintas");
            }

            Console.WriteLine();

            Console.WriteLine("pluma2 es igual a tinta 2?");
            if (pluma2 == tinta2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintas");
            }

            Console.WriteLine();

            Console.WriteLine("Plumas");
            string mostrarPluma2 = pluma2;
            string mostrarPluma3 = pluma3;
            Console.WriteLine(mostrarPluma2);
            Console.WriteLine(mostrarPluma3);

            Console.WriteLine();

            Console.WriteLine("Sumo 1 de tinta a la pluma 2");
            pluma2 += tinta2;
            mostrarPluma2 = pluma2;
            Console.WriteLine(mostrarPluma2);

            Console.WriteLine();

            Console.WriteLine("Saco 1 de tinta a la pluma 2");
            pluma2 -= tinta2;
            mostrarPluma2 = pluma2;
            Console.WriteLine(mostrarPluma2);

            Console.ReadKey();
        }
    }
}
