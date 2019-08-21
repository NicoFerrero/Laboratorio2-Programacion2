using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidadades_Ejer31
{
    public class PuestoAtencion
    {
        private static int _numeroActual;
        private Puesto _puesto;

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion._numeroActual++; 
                return PuestoAtencion._numeroActual;
            }
        }

        private PuestoAtencion()
        {
            PuestoAtencion._numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this._puesto = puesto;
        }

        public bool Atender(Cliente c)
        {
            Thread.Sleep(2000);
            return true;
        }
    }
}
