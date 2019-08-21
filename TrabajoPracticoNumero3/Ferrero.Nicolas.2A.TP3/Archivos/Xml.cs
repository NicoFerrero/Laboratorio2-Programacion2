using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool guardar(string archivo, T datos)
        {
            bool rta = true;
            XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
            XmlSerializer xml = new XmlSerializer(typeof(T));

            try
            {
                xml.Serialize(writer, datos);
                writer.Close();
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.ToString());
                rta = false;
            }

            return rta;
        }

        public bool leer(string archivo, out T datos)
        {
            bool rta = true;
            datos = default(T);

            XmlTextReader reader = new XmlTextReader(archivo);
            XmlSerializer xml = new XmlSerializer(typeof(T));

            try
            {
                datos = (T)xml.Deserialize(reader);
                reader.Close();
            }
            catch(ArchivosException e)
            {
                Console.WriteLine(e.ToString());
                rta = false;
            }

            return rta; ;
        }
    }
}
