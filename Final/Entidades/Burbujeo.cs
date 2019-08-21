using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Burbujeo
    {
        private Burbujeo()
        {
 
        }

        public static void MetodoClase()
        {
            try
            {
                Burbujeo b = new Burbujeo();
                b.MetodoInstancia();
            }
            catch(MiException ex)
            {
                Burbujeo.Escribir("Metodo Clase" + DateTime.Now);
                throw ex;
            }
        }

        public void MetodoInstancia()
        {
            Burbujeo.Escribir("Metodo Instancia" + DateTime.Now);
            throw new MiException();
        }

        public static void Escribir(string info)
        {
            try
            {
                StreamWriter escritura = new StreamWriter(@"\Burbujeo.txt", true);
                escritura.WriteLine(info);
                escritura.Close();
            }
            catch
            {
            }

        }

        public static string Leer(string path, out string info)
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
            catch (Exception)
            {
                rta = false;
            }

            return info;
        }
    }
}
