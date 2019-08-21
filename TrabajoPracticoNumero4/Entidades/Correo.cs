using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            for(int i = 0; i < mockPaquetes.Count; i++)
            {
                if(mockPaquetes[i].IsAlive)
                {
                    mockPaquetes[i].Abort();
                } 
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder cadena = new StringBuilder();
            List<Paquete> paquetes = ((Correo)elemento).paquetes;

            for (int i = 0; i < paquetes.Count; i++)
            {
                cadena.AppendLine(string.Format("{0} para {1} ({2})", paquetes[i].TrackingID, paquetes[i].DireccionEntrega, paquetes[i].Estado.ToString()));
            }

            return cadena.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            for(int i = 0; i < c.Paquetes.Count; i++)
            {
                if(c.Paquetes[i] == p)
                {
                    throw new TrackingIdRepetidoException("El ID " + c.paquetes[i].TrackingID + " es repetido, el paquete ya se encuentra en el correo");
                }
            }

            c.Paquetes.Add(p);
            Thread hilo = new Thread(new ThreadStart(p.MockCicloVida));
            c.mockPaquetes.Add(hilo);
            hilo.Start();

            return c;
        }
    }
}
