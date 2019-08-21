using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase19;

namespace EjerClase19
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("AAA", "BBB", EPuesto.Arquero);

            Console.WriteLine(j1.ToString());

            Console.ReadKey();
        }
    }
}
