using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Manzana : Fruta, ISerializable
    {
        public string distribuidora;
        private string path;

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        public string Tipo
        {
            get
            {
                return "Manzana";
            }
            set
            {
                
            }
        }

        public Manzana() : base()
        { 
        }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base(peso, color)
        {
            this.distribuidora = distribuidora;
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + string.Format(" | Tipo fruta: {0} | Carozo: {1} | Distribuidora: {2}", this.Tipo, this.TieneCarozo, this.distribuidora);
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public string RutaArchivo
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        public bool Deserializar()
        {
            bool rta = false;
            Manzana m;

            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(Manzana));
                XmlTextReader read = new XmlTextReader(this.RutaArchivo);

                m = (Manzana)serialize.Deserialize(read);
                read.Close();
                rta = true;
            }
            catch
            {
            }

            return rta; ;
        }

        public bool Serializar()
        {
            bool rta = false;

            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(Manzana));
                XmlTextWriter write = new XmlTextWriter(this.RutaArchivo ,Encoding.UTF8);

                serialize.Serialize(write, this);
                write.Close();
                rta = true;
            }
            catch (Exception)
            {
            }

            return rta;
        }
    }
}
