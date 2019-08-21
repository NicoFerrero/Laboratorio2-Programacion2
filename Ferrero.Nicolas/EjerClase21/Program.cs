using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntidadesClase21;

namespace EjerClase21
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejemplo DataTable
            DataTable tabla = Persona.TraerTodosTabla();

            foreach (DataRow row in tabla.Rows)
            {
                Console.WriteLine(row[0].ToString() + "-" + row[1].ToString() + "-" + row[2].ToString() + "-" + row[3].ToString());
            }
            #endregion

            //Persona p1 = new Persona("Juan", "Perez", 25);
            //Persona p2 = new Persona(6, "Juan", "Perez", 25);
            //Persona p3 = new Persona(6, "Jose", "Suarez", 36);
            //Persona p4 = null;
            //List<Persona> lista;

            #region Trae una persona
            /*p4 = Persona.TraerTodos(5);
            if (p4 != null)
            {
                Console.WriteLine(p4.ToString());
            }
            else
            {
                Console.WriteLine("No existe una persona con ese ID");
            }
            Console.WriteLine();*/
            #endregion

            #region Agrega persona
            /*if (p1.Agregar())
            {
                Console.WriteLine("Se agrego");
            }
            else
            {
                Console.WriteLine("No se agrego");
            }

            lista = Persona.TraerTodos();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
            Console.WriteLine();*/
            #endregion

            #region Modifica persona
            /*if (p3.Modificar())
            {
                Console.WriteLine("Se modifico");
            }
            else
            {
                Console.WriteLine("No se modifico");
            }
            Console.WriteLine();

            lista = Persona.TraerTodos();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
            Console.WriteLine();*/
            #endregion

            #region Borra persona
            /*if (Persona.Borrar(p2))
            {
                Console.WriteLine("Se borro");
            }
            else
            {
                Console.WriteLine("No se borro");
            }
            Console.WriteLine();

            lista = Persona.TraerTodos();

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
            Console.WriteLine();*/
            #endregion

            Console.ReadKey();
        }
    }
}
