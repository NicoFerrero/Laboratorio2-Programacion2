using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace EjerClase25
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Sofia", "Perez", 30, Entidades.Alumnos.ESexo.Femenino);
            Persona p3 = new Persona("Nicolas", "Ferrero", 23, Entidades.Alumnos.ESexo.Masculino);
            PersonaExternaSellada p2 = new PersonaExternaSellada("Jose", "Pepito", 45, Entidades.Externa.Sellada.ESexo.Masculino);
            object obj = null; /*= new object();*/
            List<Persona> listado = new List<Persona>();

            /*Console.WriteLine("{0} {1} {2} {3}", p1.Nombre, p1.Apellido, p1.Edad, p1.Sexo);

            Console.WriteLine(p1.ObtenerInfo());

            Console.WriteLine(p2.ObtenerInfoDll());

            Console.WriteLine(obj.EsNulo());

            Console.WriteLine(p2.ObtenerInfoDll().CantidadCaracteres());

            if (p1.Escribir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\personas.txt"))
            {
                Console.WriteLine("Escritura exitosa");
            }
            else
            {
                Console.WriteLine("Fallo esxritura");
            }*/

            /*if (p3.AgregarBD())
            {
                Console.WriteLine("Se agrego a la base de datos");
            }
            else
            {
                Console.WriteLine("No se agrego a la base de datos");
            }*/

            listado = p1.TraerTodos();

            foreach (Persona p in listado)
            {
                Console.WriteLine(p.ObtenerInfo());
            }

            Console.ReadKey();
        }
    }
}
