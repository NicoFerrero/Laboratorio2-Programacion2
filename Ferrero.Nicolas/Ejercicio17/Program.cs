using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {

            string dibujo;
            bool rta;
            bool rta1;

            Console.Title = "Ejercicio Nro 17";

            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine("El nivel del boligrafo 1 antes de pintar es {0}", boligrafo1.GetTinta());
            rta = boligrafo1.Pintar(10, out dibujo);
            if (rta == true)
            {
                Console.WriteLine("Pudo pintar el dibujo entero");
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("No pudo pintar el dibujo entero");
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("El nivel del boligrafo 1 despues de pintar es {0}", boligrafo1.GetTinta());

            Console.WriteLine();

            Console.WriteLine("El nivel del boligrafo 2 antes de pintar es {0}", boligrafo2.GetTinta());
            rta1 = boligrafo2.Pintar(51, out dibujo);
            if (rta1 == true)
            {
                Console.WriteLine("Pudo pintar el dibujo entero");
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine("No pudo pintar el dibujo entero");
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("El nivel del boligrafo 2 despues de pintar es {0}", boligrafo2.GetTinta());

            Console.WriteLine();

            Console.WriteLine("Cargo nuevamente el boligrafo 2");
            boligrafo2.Recargar();
            Console.WriteLine("Despues de la recarga el boligrafo 2 tiene {0} de nivel de tinta", boligrafo2.GetTinta());

            Console.ReadKey();
        }
    }
}
