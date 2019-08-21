using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase06;

namespace EjerClase06
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera tempera = new Tempera(ConsoleColor.Cyan, "Faber Castel", 5);
            Tempera tempera1 = new Tempera(ConsoleColor.Red, "Faber Castel", 10);

            Paleta p = 2;

            p += tempera;
            p += tempera1;
            p -= tempera;
            p -= tempera;
            p -= tempera;
            p -= tempera;
           // p -= tempera;

            Console.WriteLine((string)p);

            if (p == tempera)
            {
                Console.WriteLine("Esta la tempera");
            }
            else
            {
                Console.WriteLine("No esta la tempera");
            }

            Console.WriteLine();

            Console.WriteLine(Tempera.Mostrar(tempera));
            Console.WriteLine(Tempera.Mostrar(tempera1));

            Console.WriteLine();
            Console.WriteLine("Tempera es igual a tempera1?");

            if (tempera == tempera1)
            {
                Console.WriteLine("Las temperas son iguales");
            }
            else
            {
                Console.WriteLine("Las temperas no son iguales");
            }

            Console.WriteLine();

            int cantidad = tempera;
            Console.WriteLine("La cantidad de tempera es: {0}", cantidad);

            Console.WriteLine();

            string mostrar = (string)tempera;
            Console.WriteLine(mostrar);

            Console.WriteLine();

            tempera += 5;
            cantidad = tempera;
            Console.WriteLine("La cantidad de tempera despues de sumarle 5 es: {0}", cantidad);

            Console.WriteLine();

            tempera += tempera1;
            Console.WriteLine(Tempera.Mostrar(tempera));

            Console.ReadKey();
        }
    }
}
