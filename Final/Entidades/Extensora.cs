using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class Extensora
    {
        public static bool AgregarBD(this Producto p)
        {
            bool rta = false;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO productosDB (nombre, stock) VALUES ('" + p.nombre + "','" + p.stock + ")", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                rta = true;
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return rta;
        }

        public static string MostrarBD(this Producto p)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("SELECT nombre,stock FROM productosDB", conn);
            StringBuilder cadena = new StringBuilder();
            SqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cadena.AppendLine(string.Format("{0} - {1}", dr[0].ToString(), (int)dr[1]));
                }
            }
            catch
            { 
            }

            return cadena.ToString();
        }
    }
}
