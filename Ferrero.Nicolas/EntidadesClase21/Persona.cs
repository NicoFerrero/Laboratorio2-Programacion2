using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EntidadesClase21
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _id;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                this._edad = value;
            }
        }

        public int ID
        {
            get
            {
                return this._id;
            }
        }

        public Persona(string nombre, string apellido, int edad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }

        public Persona(int id, string nombre, string apellido, int edad):this(nombre, apellido,edad)
        {
            this._id = id;
        }

        public static List<Persona> TraerTodos(this Persona)
        {
            List<Persona> lista = new List<Persona>();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("SELECT id,nombre,apellido,edad FROM Personas", conn);
            SqlDataReader dr;
            
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    /*(int)dr[0];
                    dr[1].ToString();
                    dr[2].ToString();
                    (int)dr[3];*/

                    /*(int)dr["id"];
                    dr["nombre"].ToString();
                    dr["apellido"].ToString();
                    (int)dr["edad"];*/

                    lista.Add(new Persona((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3]));
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return lista;
        }

        public static Persona TraerTodos(int id)
        {
            Persona p = null;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("SELECT id,nombre,apellido,edad FROM Personas WHERE id = " + id, conn);
            SqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p = new Persona((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3]);
                }
                conn.Close();
                dr.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return p;
        }

        public bool Agregar()
        {
            bool rta = false;
            int comando = 0;

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("INSERT INTO Personas (nombre, apellido, edad) VALUES ('" + this._nombre + "','" + this._apellido +  "'," + this._edad + ")", conn); 
           
            try
            {
                conn.Open();
                comando = cmd.ExecuteNonQuery();
                if (comando > 0)
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

        public static bool Borrar(Persona p)
        {
            bool rta = false;
            int comando = 0;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("DELETE FROM Personas WHERE id = " + p._id, conn);

            try
            {
                conn.Open();
                comando = cmd.ExecuteNonQuery();
                if (comando > 0)
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

        public bool Modificar()
        {
            bool rta = false;
            int comando = 0;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("UPDATE Personas SET nombre = '" + this._nombre + "', apellido = '" + this._apellido + "', edad = " + this._edad + " WHERE id = " + this._id, conn);

            try 
            {
                conn.Open();
                comando = cmd.ExecuteNonQuery();
                if (comando > 0)
                {
                    rta = true;
                }
                conn.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return rta;
        }

        public static DataTable TraerTodosTabla()
        {
            DataTable tabla = new DataTable("Personas");
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("SELECT id,nombre,apellido,edad FROM Personas", conn);
            SqlDataReader dr;

            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                tabla.Load(dr);
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return tabla;
        }

        public override string ToString()
        {
            return this._id + "-" + this._nombre + "-" + this._apellido + "-" + this._edad;
        }
    }
}
