using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEjer47
{
    public class Recibo : Documento
    {
        public Recibo() : this(5)
        {
        }

        public Recibo(int numero) : base(numero)
        {
        }
    }
}
