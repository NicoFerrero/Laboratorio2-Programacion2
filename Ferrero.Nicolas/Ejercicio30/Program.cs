using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 30";

            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(2, "McLaren");
            AutoF1 a3 = new AutoF1(3, "Dodge");

            Competencia c1 = new Competencia(10, 3);

            if(a1 == a2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }
            Console.WriteLine();

            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine();
            Console.WriteLine(a2.MostrarDatos());
            Console.WriteLine();

            if(c1 + a1)
            {
                Console.WriteLine("Se agrego competidor");
            }
            else
            {
                Console.WriteLine("No se agrego competidor");
            }
            Console.WriteLine();

            if (c1 + a2)
            {
                Console.WriteLine("Se agrego competidor");
            }
            else
            {
                Console.WriteLine("No se agrego competidor");
            }
            Console.WriteLine();

            if (c1 + a3)
            {
                Console.WriteLine("Se agrego competidor");
            }
            else
            {
                Console.WriteLine("No se agrego competidor");
            }
            Console.WriteLine();

            if(c1 == a1)
            {
                Console.WriteLine("El comeptidor esta en la competencia");
            }
            else
            {
                Console.WriteLine("El comeptidor no esta en la competencia");
            }
            Console.WriteLine();

            Console.WriteLine(c1.MostrarDatos());
            Console.WriteLine();

            if (c1 - a1)
            {
                Console.WriteLine("Se elimino competidor");
            }
            else
            {
                Console.WriteLine("No se elimino competidor. No se encuentra en la lista");
            }
            Console.WriteLine();

            if (c1 == a1)
            {
                Console.WriteLine("El comeptidor esta en la competencia");
            }
            else
            {
                Console.WriteLine("El comeptidor no esta en la competencia");
            }
            Console.WriteLine();

            if (c1 - a1)
            {
                Console.WriteLine("Se elimino competidor");
            }
            else
            {
                Console.WriteLine("No se elimino competidor. No se encuentra en la lista");
            }
            Console.WriteLine();

            Console.WriteLine(c1.MostrarDatos());
            Console.WriteLine();

            Console.WriteLine(a2.MostrarDatos());
            Console.WriteLine();
            Console.WriteLine(a3.MostrarDatos());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
