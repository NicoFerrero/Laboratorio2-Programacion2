using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;

        static PaqueteDAO()
        {
            _conexion = new SqlConnection(Properties.Settings.Default.conexion);
        }

        public static bool Insertar(Paquete p)
        {
            bool rta = false;

            PaqueteDAO._comando = new SqlCommand("INSERT INTO Paquetes (direccionEntrega, trackingID, alumno) VALUES ('" + p.DireccionEntrega + "','" + p.TrackingID + "','Nicolas Ferrero')", PaqueteDAO._conexion);

            try
            {
                PaqueteDAO._conexion.Open();
                PaqueteDAO._comando.ExecuteNonQuery();
                PaqueteDAO._conexion.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return rta;
        }
    }
}
