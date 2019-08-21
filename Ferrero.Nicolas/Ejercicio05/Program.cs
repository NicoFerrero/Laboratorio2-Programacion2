using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int aux = 0;
            int aux1 = 0; 
            int sumaIz;
            int sumaDe;
            bool esEntero;

            Console.Title = "Ejercicio Nro 05";

            Console.Write("Ingrese un numero para mostrar los centros numericos hasta el: ");
            esEntero = int.TryParse(Console.ReadLine(), out numero);
            while(esEntero != true)
            {
                Console.Clear();
                Console.WriteLine("Error. El numero debe ser un entero");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Ingrese nuevamente un numero para mostrar los centros numericos hasta el: ");
                esEntero = int.TryParse(Console.ReadLine(), out numero);
            }
            for(int i = 2; i <= numero; i++)
            {
                sumaIz = 0;
                sumaDe = 0;
                for(aux = 1; aux < i; aux++)
                {
                    sumaIz += aux;
                }
                for (aux1 = i + 1; sumaIz > aux1; aux1++)
                {
                    sumaDe += aux1;
                    if ((sumaIz % sumaDe) == 0 && (sumaIz == sumaDe))
                    {
                        Console.WriteLine("{0} Es centro numerico", i);
                        break;
                    }
                }  
            }
            Console.ReadKey();
        }
    }
}
