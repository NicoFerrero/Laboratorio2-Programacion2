using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public delegate void CajonDelegado(object sender, EventArgs e);

    public class Cajon<T> : ISerializable
    {
        

        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;
        private string path;
        public event CajonDelegado EventoPrecio;

        public List<T> Frutas
        {
            get
            {
                return this._frutas;
            }
            set
            {

            }
        }

        public float PrecioTotal
        {
            get
            {
                float rta = 0;
                EventArgs e = new EventArgs();
                rta = this._frutas.Count * this._precioUnitario;
                if (rta > 25)
                {
                    this.EventoPrecio(this, e);
                }
                return rta;
            }
            set
            {

            }
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

        public Cajon()
        {
            this._frutas = new List<T>();
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            int cantidad = c._frutas.Count;

            if (cantidad < c._capacidad)
            {
                c._frutas.Add(f);
            }
            else
            {
                throw new CajonLlenoException("El cajon esta lleno, no puede agregar mas frutas");
            }

            return c;
        }

        public override string ToString()
        {
            StringBuilder cad = new StringBuilder(string.Format("Capacidad: {0} | Frutas en el cajon: {1} | Precio total del cajon: {2}", this._capacidad, this._frutas.Count, this._frutas.Count * this._precioUnitario /*this.PrecioTotal*/));
            cad.AppendLine();
            for (int i = 0; i < this._frutas.Count; i++)
            {
                cad.AppendLine(this._frutas[i].ToString());
            }

            return cad.ToString();
        }


        public bool Deserializar()
        {
            bool rta = false;
            Cajon<T> c;

            try
            {
                XmlSerializer serialize = new XmlSerializer(typeof(Cajon<T>));
                XmlTextReader read = new XmlTextReader(this.RutaArchivo);

                c = (Cajon<T>)serialize.Deserialize(read);
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
                XmlSerializer serialize = new XmlSerializer(typeof(Cajon<T>));
                XmlTextWriter write = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8);

                serialize.Serialize(write, this);
                write.Close();
                rta = true;
            }
            catch (Exception)
            {
            }

            return rta;
        }

        public void Manejador(object sender, EventArgs e)
        {
            string cadena = string.Format("Fecha y hora: {0} | Precio Cajon: {1}", DateTime.Now, ((Cajon<T>)sender)._frutas.Count * ((Cajon<T>)sender)._precioUnitario);

            try
            {
                StreamWriter escritura = new StreamWriter(((Cajon<T>)sender).RutaArchivo + @"\escritura.txt", true);
                escritura.WriteLine(cadena);
                escritura.Close();
            }
            catch
            {
            }

        }
    }
}
