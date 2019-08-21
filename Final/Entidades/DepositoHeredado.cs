using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class DepositoHeredado : Deposito, ISerializar, IDeserializar
    {
        public DepositoHeredado() : base()
        {
        }

        public bool Xml(string xml)
        {
            bool rta = false;

            XmlSerializer serialize = new XmlSerializer(typeof(Deposito));
            XmlTextWriter write = new XmlTextWriter(xml, Encoding.UTF8);

            try
            {
                serialize.Serialize(write, this);
                write.Close();
                rta = true;
            }
            catch
            { 
            }

            return rta;
        }

        bool IDeserializar.Xml(string xml, out Deposito d)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(Deposito));
            XmlTextReader read = new XmlTextReader(xml);
            bool rta = false;
            d = null;

            try
            {
                d = (Deposito)serialize.Deserialize(read);
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
