using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadCosa;

namespace EjerClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime miFecha = new DateTime(1994,05,04);

            Cosa cosa = new Cosa(23,"Nicolas", miFecha);

            Console.Write(cosa.Mostrar());

            Console.ReadKey();
            Console.Clear();

            cosa.EstablecerValor(4);
            cosa.EstablecerValor("Hola Mundo");
            cosa.EstablecerValor(DateTime.Now);

            Console.Write(cosa.Mostrar());

            Console.ReadKey();
        }
    }
}
