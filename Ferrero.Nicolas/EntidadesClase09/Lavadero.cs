using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase09
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        public String GetLavadero
        {
            get
            {
                string rta = "Precio Auto: " + this._precioAuto + "\n" + "Precio Camion: " + this._precioCamion + "\n" + "Precio Moto: " + this._precioMoto + "\n"; 

                foreach(Vehiculo v in this._vehiculos)
                {
                    rta += v.ToString() + v.Acelerar() + "\n";
                    //rta += v.Mostrar();
                    /*if (v is Auto)
                    {
                        rta += ((Auto)v).Mostrar();
                    }

                    if (v is Camion)
                    {
                        rta += ((Camion)v).Mostrar();
                    }

                    if (v is Moto)
                    {
                        rta += ((Moto)v).Mostrar();
                    }*/
                }

                return rta;
            } 
        }

        public List<Vehiculo> Vehiculo
        {
            get {return this._vehiculos;}
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        public double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            int autos = 0;
            int camiones = 0;
            int motos = 0;
            double total = 0;

            foreach (Vehiculo v in this._vehiculos)
            {
                if (v is Auto)
                {
                    autos++;
                }
                if (v is Camion)
                {
                    camiones++;
                }
                if (v is Moto)
                {
                    motos++;
                }
            }

            switch (vehiculo)
            {
                case EVehiculos.Auto:
                    total = autos * this._precioAuto;
                    break;

                case EVehiculos.Camion:
                    total = camiones * this._precioCamion;
                    break;

                case EVehiculos.Moto:
                    total = motos * this._precioMoto;
                    break;
            }

            return total;
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            int cantidad = l._vehiculos.Count;
            bool rta = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (l._vehiculos[i] == v)
                {
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        public static bool operator +(Lavadero l, Vehiculo v)
        {
            int cantidad = l._vehiculos.Count;
            bool rta = true;

            if (cantidad < 1)
            {
                l._vehiculos.Add(v);
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (l._vehiculos[i] == v)
                    {
                        rta = false;
                        break;
                    }
                }

                if (rta == true)
                {
                    l._vehiculos.Add(v);
                }
            }
        
            return rta;
        }

        public static bool operator -(Lavadero l, Vehiculo v)
        {
            int cantidad = l._vehiculos.Count;
            bool rta = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (l.Vehiculo[i] == v)
                {
                    rta = true;
                    l._vehiculos.RemoveAt(i);
                    break;
                }
            }

            return rta;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            string patenteV1 = v1.Patente;
            string patenteV2 = v2.Patente;

            return patenteV1.CompareTo(patenteV2);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            string marcaV1 = v1.Marca.ToString();
            string marcaV2 = v2.Marca.ToString();

            return marcaV1.CompareTo(marcaV2);
        }
    }
}
