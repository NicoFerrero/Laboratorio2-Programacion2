using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesEjer47;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f = new Factura(12345678);
            Factura f1 = new Factura(09876543);
            Factura f2 = new Factura(135791357);
            Recibo r = new Recibo(135791357);
            Documento d = new Documento(09876543);
            Contabiidad<Documento, Recibo> c = new Contabiidad<Documento, Recibo>();

            c = c + f;
            c = c + f1;
            c = c + f2;
            c = c + r;
            c = c + d;

            Console.ReadKey();
        }
    }
}
