using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase14;

namespace EjerClase14
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n = new Numero(5);
            Numero n1;

            Console.WriteLine("{0}", n.MiNumero);

            bool rta = Numero.Parse("10", out n1);

            if (rta == true)
            {
                Console.WriteLine("{0}", n1.MiNumero);
            }
            else
            {
                Console.WriteLine("No se pudo instanciar el numero" );
            }
            Console.WriteLine("");

            Numero n2 = new Numero(2);
            Numero n3 = new Numero(2);
            Numero n4 = new Numero(3);
            Numero n5 = new Numero(4);
            Numero n6 = new Numero(5);
            Numero n7 = new Numero(-2);

            ColectoraDeNumeros c = new ColectoraDeNumeros(ETipoNumero.Positivo);

            try
            {
                c += n2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c += n3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c += n4;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c += n5;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c += n6;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c += n7;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("");
            }
            
            Console.WriteLine(c.ToString());
            

            try
            {
                c -= n2;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("");
            Console.WriteLine(c.ToString());
            Console.WriteLine("");

            bool rta1 = Verificadora.VerificarNumero(ETipoNumero.Impar, n2);
            Console.WriteLine("{0}", rta1);

            Console.ReadKey();
        }
    }
}
