using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<LLamada> _listaDeLlamadas;
        protected string _razonSocial;

        public List<LLamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        public float GananciaLocal
        {
            get
            {
                float rta = 0;
                for (int i = 0; i < this.Llamadas.Count; i++)
                {
                    if (this._listaDeLlamadas[i] is Local)
                    {
                        rta += ((Local)this._listaDeLlamadas[i]).CostoLLamada;
                    }
                }
                return rta;
            }
        }

        public float GananciaProvincial
        {
            get
            {
                float rta = 0;
                for (int i = 0; i < this.Llamadas.Count; i++)
                {
                    if (this._listaDeLlamadas[i] is Provincial)
                    {
                        rta += ((Provincial)this._listaDeLlamadas[i]).CostoLLamada;
                    }
                }
                return rta;
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.GananciaLocal + this.GananciaProvincial;
            }
        }

        private Centralita()
        {
            this._listaDeLlamadas = new List<LLamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float rta = 0;

            switch (tipo)
            {
                case TipoLlamada.Local:
                    rta = this.GananciaLocal;
                    break;

                case TipoLlamada.Provincial:
                    rta = this.GananciaProvincial;
                    break;

                case TipoLlamada.Todas:
                    rta = this.GananciaTotal;
                    break;
            }

            return rta;
        }

        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder("Razon Social: " + this._razonSocial + "\n" + "Ganancia total: " + this.GananciaTotal + "\n" + "Ganancia Local: " + this.GananciaLocal + "\n" + "Ganancia Provincial: " + this.GananciaProvincial + "\n");
            for(int i = 0; i < this.Llamadas.Count; i++)
            {
                cadena.Append(this._listaDeLlamadas[i].ToString());
            }

            return cadena.ToString();
        }

        private void AgregarLLamada(LLamada nuevaLLamada)
        {
            this._listaDeLlamadas.Add(nuevaLLamada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita central, LLamada nuevaLLamada)
        {
            int cantidad = central.Llamadas.Count;
            bool rta = false;

            if(cantidad > 0)
            {
                for(int i = 0; i < cantidad; i++)
                {
                    if(central.Llamadas[i] == nuevaLLamada)
                    {
                        rta = true;
                        break;
                    }
                }
            }

            return rta;
        }

        public static bool operator !=(Centralita central, LLamada nuevaLLamada)
        {
            return !(central == nuevaLLamada);
        }

        public static bool operator +(Centralita central, LLamada nuevaLLamada)
        {
            int cantidad = central.Llamadas.Count;
            bool esta = false;
            bool rta  = false;

            if (cantidad == 0)
            {
                central.AgregarLLamada(nuevaLLamada);
                rta = true;
            }
            else
            {
                if (central == nuevaLLamada)
                {
                    esta = true;
                }

                if (esta != true)
                {
                    central.AgregarLLamada(nuevaLLamada);
                    rta = true;
                }
                else
                {
                    Console.WriteLine("La llamada ya se encuentra registrada");
                }
            }

            return rta;
        }

        public void OrdenarLLamdas()
        {
            this.Llamadas.Sort(LLamada.OrdenarPorDuracion);
        }
    }
}
