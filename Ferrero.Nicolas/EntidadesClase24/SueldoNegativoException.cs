using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase24
{
    public class SueldoNegativoException : Exception
    {
        public SueldoNegativoException(string msg) : base(msg)
        { 
        }
    }
}
