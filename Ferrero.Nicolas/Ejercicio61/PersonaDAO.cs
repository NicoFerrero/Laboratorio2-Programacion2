using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        public static bool Guardar(Persona p)
        {
            bool rta = false;
            int rtaQuery = 0;
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.conexion);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO persona (Nombre, Apellido) VALUES ('" + p.Nombre + "', '" + p.Apellido + "')", conn);

            try
            {
                conn.Open();
                rtaQuery = cmd.ExecuteNonQuery();
                if(rtaQuery > 0)
                {
                    rta = true;
                }
                conn.Close();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return rta;
        }

        public static List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.conexion);
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Nombre, Apellido FROM persona ", conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    lista.Add(new Persona((int)dr[0], dr[1].ToString(), dr[2].ToString()));
                }
                conn.Close();
                dr.Close();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return lista;
        }

        public static Persona Leer(int id)
        {
            Persona persona = null;
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.conexion);
            MySqlCommand cmd = new MySqlCommand("SELECT ID, Nombre, Apellido FROM persona WHERE ID = " + id, conn);
            MySqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    persona = new Persona((int)dr[0], dr[1].ToString(), dr[2].ToString());
                }
                conn.Close();
                dr.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return persona;
        }

        public static bool Borrar(int id)
        {
            bool rta = false;
            int rtaQuery = 0;
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.conexion);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM persona WHERE ID = " + id, conn);

            try
            {
                conn.Open();
                rtaQuery = cmd.ExecuteNonQuery();
                if (rtaQuery > 0)
                {
                    rta = true;
                }
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return rta;
        }

        public static  bool Modificar(int id, Persona p)
        {
            bool rta = false;
            int rtaQuery = 0;
            MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.conexion);
            MySqlCommand cmd = new MySqlCommand("UPDATE persona SET WHERE ID = " + id, conn);

            try
            {
                conn.Open();
                rtaQuery = cmd.ExecuteNonQuery();
                if (rtaQuery > 0)
                {
                    rta = true;
                }
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return rta;
        }
    }
}
