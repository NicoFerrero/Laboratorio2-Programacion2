using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador;

            Console.Title = "Ejercicio Nro 03";

            Console.WriteLine("Ingrese un numero para calcular todos los numeros primos hasta este");
            numero = int.Parse(Console.ReadLine());
            for(int i = 2; i<= numero; i++)
            {
                acumulador = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        acumulador++;
                    }
                }
                if(acumulador == 2)
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.ReadKey();
        }
    }
}
