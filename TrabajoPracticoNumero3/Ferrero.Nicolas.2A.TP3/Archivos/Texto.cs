using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto
    {
        public static bool guardar(string archivo, string datos)
        {
            bool rta = true;
            StreamWriter str = new StreamWriter(archivo, false);

            try
            {
                str.Write(datos);
                str.Close();
            }
            catch (IOException e)
            {
                Console.Write(e.StackTrace);
                rta = false;
            }

            return rta; ;
        }

        public static bool leer(string archivo, out string datos)
        {
            bool rta = true;
            StreamReader str = new StreamReader(archivo);
            datos = "";

            try
            {
                datos = str.ReadToEnd();
                str.Close();
            }
            catch(IOException e)
            {
                Console.Write(e.StackTrace);
                rta = false;
            }
            
            return rta;
        }
    }
}
