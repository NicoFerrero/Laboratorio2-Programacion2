using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using Entidades.Alumnos;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.Alumnos
{
    public static class Extensora
    {
        public static string ObtenerInfo(this Persona p)
        {
            return string.Format("{0} {1} {2} {3}", p.Nombre, p.Apellido, p.Edad, p.Sexo);
        }

        public static string ObtenerInfoDll(this PersonaExternaSellada ps)
        {
            return string.Format("{0} {1} {2} {3}", ps.Nombre, ps.Apellido, ps.Edad, ps.Sexo);
        }

        public static bool EsNulo(this object obj)
        {
            return (obj == null);
        }

        public static int CantidadCaracteres(this String str)
        {
            return str.Length;
        }

        public static bool Escribir(this Persona p, string path)
        {
            bool rta = true;
            
            try
            {
                StreamWriter str = new StreamWriter(path, true);
                str.WriteLine(p.ObtenerInfo());
                str.Close();
            }
            catch
            {
                rta = false;
            }

            return rta;
        }

        public static bool AgregarBD(this Persona p)
        {
            bool rta = false;
            int escritura = 0;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO datos (apellido, nombre, sexo) VALUES ('" + p.Apellido + "', '" + p.Nombre + "', " + (int)p.Sexo + ")", conn);

            try
            {
                conn.Open();
                escritura = cmd.ExecuteNonQuery();
                if (escritura > 0)
                {
                    rta = true;
                }
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return rta;
        }

        public static List<Persona> TraerTodos(this Persona p)
        {
            List<Persona> personas = new List<Persona>();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("SELECT apellido, nombre, sexo FROM datos", conn);
            SqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    personas.Add(new Persona(dr[1].ToString(), dr[0].ToString(), 1, (Entidades.Alumnos.ESexo)dr[2]));
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return personas;
        }
    }
}
