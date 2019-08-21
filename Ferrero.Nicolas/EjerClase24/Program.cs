using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase24;

namespace EjerClase24
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e2 = new Empleado("Juan", "Perez", 98765432);

            e2.SueldoCero += new DelegadoSueldoCero(e2.ManejadorEvento);
            e2.SueldoMaximo += new DelegadoLimiteSueldo(e2.ManejadorEvento2);
            e2.SueldoMaximoMejorado += new DelegadoLimiteSueldoMejorado(e2.ManejadorEvento3);

            try
            {
                e2.Sueldo = -10;
            }
            catch (SueldoNegativoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.WriteLine(e2.ToString());

            Console.ReadKey();
        }
    }
}
