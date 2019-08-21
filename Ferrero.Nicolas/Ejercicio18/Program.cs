using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 18";

            Punto p1 = new Punto(1, 2);
            Punto p3 = new Punto(7, 5);

            Rectangulo r1 = new Rectangulo(p1, p3);

            Rectangulo.Mostrar(r1);

            Console.ReadKey();
        }
    }
}
