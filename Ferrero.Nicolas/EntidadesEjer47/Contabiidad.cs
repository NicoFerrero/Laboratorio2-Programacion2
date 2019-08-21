using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjer47
{
    public class Contabiidad<T, U> 
        where U : Documento, new()
        where T : Documento

    {
        private List<T> _egresos;
        private List<U> _ingresos;

        public Contabiidad()
        {
            this._egresos = new List<T>();
            this._ingresos = new List<U>();
        }

        public static Contabiidad<T, U> operator +(Contabiidad<T, U> c, T egreso)
        {
            c._egresos.Add(egreso);
            return c;
        }

        public static Contabiidad<T, U> operator +(Contabiidad<T, U> c, U ingreso)
        {
            c._ingresos.Add(ingreso);
            return c;
        }
    }
}
