using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            Alumno alumno1 = new Alumno("Jose", "Diaz", 100);
            Alumno alumno2 = new Alumno("Carlos", "Garcia", 101);
            Alumno alumno3 = new Alumno("Juan", "Perez", 102);

            alumno1.Estudiar(4, 4);
            alumno2.Estudiar(5, 1);
            alumno3.Estudiar(8, 1);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            alumno1.Mostrar();
            Console.WriteLine();
            alumno2.Mostrar();
            Console.WriteLine();
            alumno3.Mostrar();

            Console.ReadKey();
        }
    }
}
