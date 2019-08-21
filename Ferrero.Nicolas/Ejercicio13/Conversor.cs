using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalABinario(double num)
        {
            long m = BitConverter.DoubleToInt64Bits(num);
            string binaryResult = Convert.ToString(m, 2);
            return binaryResult;
        }
    }
}
