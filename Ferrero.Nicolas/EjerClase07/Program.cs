using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase07;

namespace EjerClase07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 29";

            bool rta;

            Jugador j1 = new Jugador("carlos", 45678912, 27, 30);
            Jugador j2 = new Jugador("juan", 98765432, 10, 15);
            Jugador j3 = new Jugador("jose", 12345678, 40, 12);
            Jugador j4 = new Jugador("juan", 12345678, 40, 12);

            Equipo e1 = new Equipo(4, "independiente");

            rta = e1 + j1;
            if (rta == true)
            {
                Console.WriteLine("Ingreso");
            }
            else
            {
                Console.WriteLine("No Ingreso");
            }

            rta = e1 + j2;
            if (rta == true)
            {
                Console.WriteLine("Ingreso");
            }
            else
            {
                Console.WriteLine("No Ingreso");
            }

            rta = e1 + j3;
            if (rta == true)
            {
                Console.WriteLine("Ingreso");
            }
            else
            {
                Console.WriteLine("No Ingreso");
            }

            rta = e1 + j4;
            if (rta == true)
            {
                Console.WriteLine("Ingreso");
            }
            else
            {
                Console.WriteLine("No Ingreso");
            }

            Console.ReadKey();
        }
    }
}
