using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase20;

namespace EjerClase20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rta;
            bool rta1;

            Alumno a1 = new Alumno(1000, "juan", "perez", 12345678);
            Alumno a2 = new Alumno(1001, "pedro", "gimenez", 23456789);
            Alumno a3;
            Profesor p1 = new Profesor("programador", "carlos", "sanchez", 98765432);
            Profesor p2;
            Aula aula = new Aula(10);
            Aula aula1;
            XML<Alumno> listado = new XML<Alumno>();
            XML<Profesor> listado1 = new XML<Profesor>();
            XML<List<Alumno>> listado3 = new XML<List<Alumno>>();
            XML<List<Persona>> listado5 = new XML<List<Persona>>();
            XML<Aula> listado8 = new XML<Aula>();
            List<Alumno> listado2 = new List<Alumno>();
            List<Alumno> listado4 = new List<Alumno>();
            List<Persona> listado6 = new List<Persona>();
            List<Persona> listado7 = new List<Persona>();

            listado6.Add(a1);
            listado6.Add(a2);
            listado6.Add(p1);

            listado2.Add(a1);
            listado2.Add(a2);

            aula.Lista.Add(a1);
            aula.Lista.Add(a2);
            aula.Lista.Add(p1);

            Console.Write(aula.ToString());
            Console.WriteLine();
            
            rta = listado.GuardarXML("alumno.xml", a1);

            if (rta == true)
            {
                Console.WriteLine("Se serializo correctamente");
            }
            else
            {
                Console.WriteLine("No se serializo");
            }
            Console.WriteLine();

            rta1 = listado.LeerXML("alumno.xml", out a3);

            if (rta1 == true)
            {
                Console.WriteLine("Se deserializo correctamente");
                Console.WriteLine(a3.ToString());
            }
            else
            {
                Console.WriteLine("No se deserializo");
            }
            Console.WriteLine();

            rta = listado1.GuardarXML("profesor.xml", p1);

            if (rta == true)
            {
                Console.WriteLine("Se serializo correctamente");
            }
            else
            {
                Console.WriteLine("No se serializo");
            }
            Console.WriteLine();

            rta1 = listado1.LeerXML("profesor.xml", out p2);

            if (rta1 == true)
            {
                Console.WriteLine("Se deserializo correctamente");
                Console.WriteLine(p2.ToString());
            }
            else
            {
                Console.WriteLine("No se deserializo");
            }
            Console.WriteLine();

            rta = listado3.GuardarXML("alumnos.xml", listado2);
            if (rta == true)
            {
                Console.WriteLine("Se serializo correctamente");
            }
            else
            {
                Console.WriteLine("No se serializo");
            }
            Console.WriteLine();

            rta1 = listado3.LeerXML("alumnos.xml", out listado4);

            if (rta1 == true)
            {
                Console.WriteLine("Se deserializo correctamente");
                Console.WriteLine(p2.ToString());
            }
            else
            {
                Console.WriteLine("No se deserializo");
            }
            Console.WriteLine();

            rta = listado5.GuardarXML("personas.xml", listado6);
            if (rta == true)
            {
                Console.WriteLine("Se serializo correctamente");
            }
            else
            {
                Console.WriteLine("No se serializo");
            }
            Console.WriteLine();

            rta1 = listado5.LeerXML("personas.xml", out listado7);

            if (rta1 == true)
            {
                Console.WriteLine("Se deserializo correctamente");
                Console.WriteLine(p2.ToString());
            }
            else
            {
                Console.WriteLine("No se deserializo");
            }
            Console.WriteLine();



            rta = listado8.GuardarXML("aula.xml", aula);
            if (rta == true)
            {
                Console.WriteLine("Se serializo correctamente");
            }
            else
            {
                Console.WriteLine("No se serializo");
            }
            Console.WriteLine();

            rta1 = listado8.LeerXML("aula.xml", out aula1);

            if (rta1 == true)
            {
                Console.WriteLine("Se deserializo correctamente");
                Console.WriteLine(p2.ToString());
            }
            else
            {
                Console.WriteLine("No se deserializo");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
