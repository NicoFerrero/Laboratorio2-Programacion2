using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase18;

namespace EjerClase18
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion a1 = new Avion(1563.3, 900);
            Privado a2 = new Privado(2005.3, 980, 10);
            Comercial a3 = new Comercial(6543.2, 875, 500);
            Deportivo d1 = new Deportivo(856.36, "aaa345", 580);
            Carreta c1 = new Carreta(200);

            Console.WriteLine("Avion");
            Console.WriteLine("Impuesto nacional {0}", Gestion.MostrarImpuestoNacional(a1));
            Console.WriteLine("Impuesto provincial {0}\n", Gestion.MostrarImpuestoProvincial(a1));

            Console.WriteLine("Avion privado");
            Console.WriteLine("Impuesto nacional {0}", Gestion.MostrarImpuestoNacional(a2));
            Console.WriteLine("Impuesto provincial {0}\n", Gestion.MostrarImpuestoProvincial(a2));

            Console.WriteLine("Avion comercial");
            Console.WriteLine("Impuesto nacional {0}", Gestion.MostrarImpuestoNacional(a3));
            Console.WriteLine("Impuesto provincial {0}\n", Gestion.MostrarImpuestoProvincial(a3));

            Console.WriteLine("Auto deportivo");
            Console.WriteLine("Impuesto nacional {0}", Gestion.MostrarImpuestoNacional(d1));
            Console.WriteLine("Impuesto provincial {0}\n", Gestion.MostrarImpuestoProvincial(d1));

            Console.WriteLine("carreta");
            Console.WriteLine("Impuesto provincial {0}\n", Gestion.MostrarImpuestoProvincial(c1));

            d1.MostrarPatente();
            d1.MostrarPrecio();

            Console.ReadKey();
        }
    }
}
