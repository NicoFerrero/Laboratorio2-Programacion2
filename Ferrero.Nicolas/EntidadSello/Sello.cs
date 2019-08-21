using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadSello
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static void Imprimir()
        {
            bool rta;
            string mensajeValido = "";
            rta = Sello.TryParse(Sello.mensaje, out mensajeValido);
            if (rta == true)
            {
                mensajeValido = Sello.ArmarFormatoMensaje();
                Console.ForegroundColor = Sello.color;
                Console.WriteLine("{0}", mensajeValido);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public static void Borrar()
        {
            Console.Clear();
        }

        private static string ArmarFormatoMensaje()
        {
            int len = Sello.mensaje.Length;
            string cadena = "";

            for (int i = 0; i < len + 2; i++)
            {
                cadena += "*";
            }
            cadena += "\n" + "*" + Sello.mensaje + "*" + "\n";
            for (int i = 0; i < len + 2; i++)
            {
                cadena += "*";
            }
            return cadena;
        }

        private static bool TryParse(string mensaje, out string stringSalida)
        {
            bool rta;
            int len = Sello.mensaje.Length;

            if(len < 1)
            {
                rta = false;
            }
            else
            {
                rta = true;
            }
            stringSalida = Sello.mensaje; 

            return rta;
        }
    }
}
