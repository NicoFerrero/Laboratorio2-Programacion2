using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadSello.Sello.mensaje = "Programacion";
            EntidadSello.Sello.color = ConsoleColor.Red; 
            EntidadSello.Sello.Imprimir();
            Console.ReadLine();

            EntidadSello.Sello.Borrar();
            EntidadSello.Sello.mensaje = "";
            EntidadSello.Sello.Imprimir();
            Console.ReadLine();

            EntidadSello.Sello.Borrar();
            Console.WriteLine("Presione enter para salir");
            Console.ReadLine();
        }
    }
}
