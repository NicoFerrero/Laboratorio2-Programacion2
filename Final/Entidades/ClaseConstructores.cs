using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.form;

namespace Entidades
{
    public class ClaseConstructores
    {
        private string _nonbre;
        private static List<int> _numeros;

        public string Nombre
        {
            set
            {
                this._nonbre = value;
                //MessageBox.Show("Propiedad solo escritura");
            }
        }

        public List<int> Numeros
        {
            get
            {
                return ClaseConstructores._numeros;
            }
        }

        static ClaseConstructores()
        {
            ClaseConstructores.Instanciar();
            //MessageBox.Show("Constructor de clase");
        }

        public ClaseConstructores() : this("sin nombre", new List<int>())
        {
            //MessageBox.Show("Constructor default");
        }

        public ClaseConstructores(string nombre, List<int> numeros)
        {
            this.PonerNombre(nombre);
            ClaseConstructores._numeros = numeros;
            //MessageBox.Show("Constructor 2 parametros");
        }

        private static void Instanciar()
        {
            ClaseConstructores._numeros = new List<int>();
            //MessageBox.Show("Metodo de clase");
        }

        private void PonerNombre(string nombre)
        {
            this.Nombre = nombre;
            //MessageBox.Show("Metodo de instancia");
        }
    }
}
