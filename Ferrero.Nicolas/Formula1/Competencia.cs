using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _autosCompitiendo;

        private Competencia()
        {
            this._cantidadCompetidores = 5;
            this._cantidadVueltas = 5;
            this._autosCompitiendo = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this() 
        {
            this._cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            return "Autos compitiendo: " + this._autosCompitiendo.Count + "\n" + "Lugares para competidores: " + this._cantidadCompetidores + "\n" + "Cantidad de vueltas: " + this._cantidadVueltas;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            int cantidad = c._autosCompitiendo.Count;
            bool rta = true;

            if(cantidad == 0)
            {
                a.SetCombustible();
                a.SetVueltas(c._cantidadVueltas);
                a.SetEnCompetencia();
                c._autosCompitiendo.Add(a);
            }
            else
            {
                for(int i = 0; i < cantidad; i++)
                {
                    if(c == a || c._cantidadCompetidores <= cantidad)
                    {
                        rta = false;
                        break;
                    }
                }

                if(rta == true)
                {
                    a.SetCombustible();
                    a.SetVueltas(c._cantidadVueltas);
                    a.SetEnCompetencia();
                    c._autosCompitiendo.Add(a);
                }
            }

            return rta;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            int cantidad = c._autosCompitiendo.Count;
            bool rta = false;

            for(int i= 0; i < cantidad; i++)
            {
                if(c == a)
                {
                    c._autosCompitiendo.RemoveAt(i);
                    rta = true;
                    break;
                }
            }


            return rta;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool rta = false;
            int cantidad = c._autosCompitiendo.Count;

            for(int i = 0; i < cantidad; i++)
            {
                if(c._autosCompitiendo[i] == a)
                {
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
