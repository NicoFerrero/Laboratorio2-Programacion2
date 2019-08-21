using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14
{
    public class Numero
    {
        private int _numero;

        public int MiNumero
        {
            get
            {
                return this._numero;
            }
        }

        public Numero(int numero)
        {
            this._numero = numero;
        }

        public static int operator +(Numero n1, Numero n2)
        {
            return n1.MiNumero + n2.MiNumero;
        }
        public static int operator -(Numero n1, Numero n2)
        {
            return n1.MiNumero - n2.MiNumero;
        }

        public static int operator *(Numero n1, Numero n2)
        {
            return n1.MiNumero * n2.MiNumero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return (double)n1.MiNumero / n2.MiNumero;
        }

        public static bool Parse(string s, out Numero n)
        {
            bool rta;
            n = null;
            int numero;

            try
            {
                numero = int.Parse(s);
                n = new Numero(numero);
                rta = true;
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
                rta = false;
            }

            return rta;
        }
    }
}
