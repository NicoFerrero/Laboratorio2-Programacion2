using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase09;

namespace EjerClase09
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto(5, "aaa1015", 4, EMarcas.Honda);
            Auto a1 = new Auto(4, "aaa1015", 4, EMarcas.Honda);
            Camion c = new Camion(7500, "ccc1025", 6, EMarcas.Scania);
            Moto m = new Moto(400, "ddd1030", 2, EMarcas.Iveco);
            Lavadero l = new Lavadero(5.25F, 10.5F, 7.75F);

            if(a.Equals(a1))
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
            Console.WriteLine();

            Console.WriteLine(a.ToString());
            Console.WriteLine(a1.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(m.ToString());

            //Agrego un auto
            if(l + c)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
            Console.WriteLine();

            //Intento agregar el mismo auto 
            if (l + a)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
            Console.WriteLine();

            //Agrego otro auto
            if (l + a1)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
            Console.WriteLine();

            //Agrego una moto
            if (l + m)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
            Console.WriteLine();

            //Agrego un camion
            if (l + a)
            {
                Console.WriteLine("Se agrego correctamente");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
            Console.WriteLine();

            Console.WriteLine("El total facturado es {0}", l.MostrarTotalFacturado());

            Console.WriteLine("El total facturado por autos es {0}", l.MostrarTotalFacturado(EVehiculos.Auto));

            Console.WriteLine("El total facturado por camiones es {0}", l.MostrarTotalFacturado(EVehiculos.Camion));

            Console.WriteLine("El total facturado por motos es {0}", l.MostrarTotalFacturado(EVehiculos.Moto));

            Console.WriteLine();

            Console.WriteLine(l.GetLavadero);

            //Me fijo si el auto esta en el lavadero
            if (l == a)
            {
                Console.WriteLine("El auto se encuentra en el lavadero");
            }
            else
            {
                Console.WriteLine("El auto no se encuentra en el lavadero");
            }
            Console.WriteLine();

            //Intento eliminar un auto
            if (l - a)
            {
                Console.WriteLine("Se elimino el auto correctamente");
            }
            else
            {
                Console.WriteLine("No se elimino el auto");
            }
            Console.WriteLine();

            //Me vuelvo a fijar si el auto esta en el lavadero
            if (l == a)
            {
                Console.WriteLine("El auto se encuentra en el lavadero");
            }
            else
            {
                Console.WriteLine("El auto no se encuentra en el lavadero");
            }
            Console.WriteLine();

            //Intento eliminar el mismo auto
            if (l - a)
            {
                Console.WriteLine("Se elimino el auto correctamente");
            }
            else
            {
                Console.WriteLine("No se elimino el auto");
            }
            Console.WriteLine();

            Console.WriteLine("El total facturado es {0}", l.MostrarTotalFacturado());

            Console.WriteLine("El total facturado por autos es {0}", l.MostrarTotalFacturado(EVehiculos.Auto));

            Console.WriteLine("El total facturado por camiones es {0}", l.MostrarTotalFacturado(EVehiculos.Camion));

            Console.WriteLine("El total facturado por motos es {0}", l.MostrarTotalFacturado(EVehiculos.Moto));

            Console.WriteLine();

            Console.WriteLine(l.GetLavadero);

            l.Vehiculo.Sort(l.OrdenarVehiculosPorMarca);

            Console.WriteLine(l.GetLavadero);

            l.Vehiculo.Sort(Lavadero.OrdenarVehiculosPorPatente);

            Console.WriteLine(l.GetLavadero);

            Console.ReadKey();
        }
    }
}
