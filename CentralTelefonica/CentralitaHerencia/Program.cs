using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Telefonica");
            Local l1 = new Local("Avellaneda", 50, "Lanus", 2.65F);
            Provincial l2 = new Provincial("Buenos Aires", Franja.Franja_1, 40, "Cordoba");
            Local l3 = new Local("Barracas", 30, "Palermo", 1.99F);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            if(central + l1)
            {
                Console.WriteLine("Se agrego la llamada");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la llamada");
            }
            Console.WriteLine(central.ToString());

            if (central + l2)
            {
                Console.WriteLine("Se agrego la llamada");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la llamada");
            }
            Console.WriteLine(central.ToString());

            if (central + l3)
            {
                Console.WriteLine("Se agrego la llamada");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la llamada");
            }
            Console.WriteLine(central.ToString());

            if (central + l4)
            {
                Console.WriteLine("Se agrego la llamada");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la llamada");
            }
            Console.WriteLine(central.ToString());

            if (central + l1)
            {
                Console.WriteLine("Se agrego la llamada");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la llamada");
            }
            Console.WriteLine(central.ToString());

            central.OrdenarLLamdas();
            Console.WriteLine(central.ToString());

            Console.ReadKey();
        }
    }
}
