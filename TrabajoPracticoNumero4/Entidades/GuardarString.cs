using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardarString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool rta = true;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo;

            try
            {
                StreamWriter escritura = new StreamWriter(path, true);
                escritura.WriteLine(texto);
                escritura.Close();
            }
            catch
            {
                rta = false;
            }

            return rta;
        }
    }
}
