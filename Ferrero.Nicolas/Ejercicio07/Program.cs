using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;
            string anio;
            string fechaArmada;
            TimeSpan dias;
            DateTime fechaActual = DateTime.Now;
            DateTime fechaNacimiento;

            Console.Title = "Ejercicio Nro 07";

            Console.WriteLine("Ingrese el dia en que nacio");
            dia = Console.ReadLine();
            Console.WriteLine("Ingrese el mes en que nacio");
            mes = Console.ReadLine();
            Console.WriteLine("Ingrese el año en que nacio");
            anio = Console.ReadLine();
            fechaArmada = dia + "/" + mes + "/" + anio;
            fechaNacimiento = DateTime.Parse(fechaArmada);

            dias = fechaActual.Date - fechaNacimiento.Date;
            Console.WriteLine("Días vividos {0}", dias.Days);


            Console.ReadKey();
        }
    }
}
