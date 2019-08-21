using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase14
{
    public static class Verificadora
    {
        public static bool VerificarNumero(ETipoNumero tipo, Numero n)
        {
            bool rta = false;
            switch (tipo)
            {
                case ETipoNumero.Cero:
                    if (n.MiNumero == 0)
                    {
                        rta = true;
                    }
                    break;

                case ETipoNumero.Impar:
                    if ((n.MiNumero % 2) == 1)
                    {
                        rta = true;
                    }
                    break;

                case ETipoNumero.Negativo:
                    if(n.MiNumero < 0)
                    {
                        rta = true;
                    }
                    break;

                case ETipoNumero.Par:
                    if ((n.MiNumero % 2) == 0)
                    {
                        rta = true;
                    }
                    break;

                case ETipoNumero.Positivo:
                    if (n.MiNumero > 0)
                    {
                        rta = true;
                    }
                    break;
            }

            return rta;
        }
    }
}
