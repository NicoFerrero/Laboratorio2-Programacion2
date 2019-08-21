using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);
        
        private string _direccionEntrega;
        private string _trackingID;
        private EEstado _estado;

        public event Paquete.DelegadoEstado InformaEstado;

        public string DireccionEntrega
        {
            get
            {
                return this._direccionEntrega;
            }
            set
            {
                this._direccionEntrega = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this._trackingID;
            }
            set
            {
                this._trackingID = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this._estado;
            }
            set
            {
                this._estado = value;
            }
        }

        public Paquete(string direcionEntrega, string trackingID)
        {
            this.DireccionEntrega = direcionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        public void MockCicloVida()
        {
            do
            {
                Thread.Sleep(10000);
                ++this._estado;
                this.InformaEstado(this, new EventArgs());
            }
            while (this._estado != Paquete.EEstado.Entregado);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception ex)
            {
            }
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete paquete = (Paquete)elemento;
            return string.Format("{0} para {1}", paquete.TrackingID, paquete.DireccionEntrega);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool rta = false;

            if(string.Equals(p1.TrackingID, p2.TrackingID) == true)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return this.MostrarDatos((IMostrar<Paquete>)this);
        }

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
