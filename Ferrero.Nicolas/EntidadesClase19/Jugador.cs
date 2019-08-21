using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesClase19
{
    [Serializable]

    public class Jugador : ISerializableBinario, ISerializableXML
    {
        protected string _nombre;
        protected string _apellido;
        protected EPuesto _puesto;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }

            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }

            set
            {
                this._apellido = value;
            }
        }

        public EPuesto Puesto
        {
            get
            {
                return this._puesto;
            }

            set
            {
                this._puesto = value;
            }
        }

        public Jugador()
        { 
        }

        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._puesto = puesto;
        }

        public override string ToString()
        {
            return this.Nombre + "-" + this.Apellido + "-" + this.Puesto;
        }

        public static bool TraerUno(string path, Jugador j1, out Jugador j2)
        {
            string info = "";
            string [] nombres;
            string [] cadObj;
            j2 = null;
            bool rta = false;

            if(AdministradorDeArchivos.Leer(path, out info) == true)
            {
                nombres = info.Split('\n');

                foreach (string items in nombres)
                {
                    cadObj = items.Split('-');
                    if (j1._nombre == cadObj[0] && j1._apellido == cadObj[1] && j1._puesto.ToString() == (cadObj[2].Trim()))
                    {
                        j2 = new Jugador(cadObj[0], cadObj[1], (EPuesto)(Enum.Parse(typeof(EPuesto), cadObj[2])));
                        rta = true;
                        break;
                    }
                }
            }

            return rta;
        }

        void ISerializableBinario.Serializar()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("jugadores.dat", FileMode.Create);

            bf.Serialize(fs, this);
            fs.Close();
        }

        Jugador ISerializableBinario.Deserializar()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("jugadores.dat", FileMode.Open);
            Jugador j;

            j = (Jugador)bf.Deserialize(fs);
            fs.Close();

            return j;
        }

        void ISerializableXML.Serializar()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(Jugador));
            XmlTextWriter write = new XmlTextWriter("jugadores.xml", Encoding.UTF8);

            serialize.Serialize(write, this);
            write.Close();
        }

        Jugador ISerializableXML.Deserializar()
        {
            XmlSerializer serialize = new XmlSerializer(typeof(Jugador));
            XmlTextReader read = new XmlTextReader("jugadores.xml");
            Jugador j;

            j =  (Jugador)serialize.Deserialize(read);
            read.Close();

            return j;
        }
    }
}
