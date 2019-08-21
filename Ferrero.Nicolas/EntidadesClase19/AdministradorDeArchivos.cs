using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesClase19
{
    public static class AdministradorDeArchivos
    {
        public static bool Escribir(string path, string info, bool append)
        {
            bool rta = true;

            try
            {
                StreamWriter escritura = new StreamWriter(path, append);
                escritura.WriteLine(info);
                escritura.Close();
            }
            catch
            {
                rta = false;
            }

            return rta;
        }

        public static bool Leer(string path, out string info)
        {
            bool rta = true;
            info = "";

            try
            {
                StreamReader lectura = new StreamReader(path);
                info = lectura.ReadToEnd();
                //info = lectura.ReadLine();
                lectura.Close();
            }
            catch(Exception)
            {
                rta = false;
            }

            return rta;
        }
    }
}
