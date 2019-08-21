using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesClase20
{
    public class XML<T>
    {
        public bool GuardarXML(string path, T a)
        {
            bool rta = false;

            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(T));
                XmlTextWriter write = new XmlTextWriter(path, Encoding.UTF8);

                serialize.Serialize(write, a);
                write.Close();
                rta = true;
            }
            catch (Exception)
            {
            }

            return rta;
        }

        public bool LeerXML(string path, out T a)
        {
            bool rta = false;
            a = default(T);

            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(T));
                XmlTextReader read = new XmlTextReader(path);

                a = (T)serialize.Deserialize(read);
                read.Close();
                rta = true;
            }
            catch
            {
            }

            return rta;
        }
    }
}
