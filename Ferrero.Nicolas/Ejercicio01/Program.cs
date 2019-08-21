using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            float minimo = 0;
            float maximo = 0;
            float sumatoria = 0;
            float promedio;

            Console.Title = "Ejercicio Nro 01";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (maximo < numero)
                    {
                        maximo = numero;
                    }
                    if (minimo > numero)
                    {
                        minimo = numero;
                    }
                }
                sumatoria += numero;
            }

            promedio = sumatoria / 5;
            Console.Clear();
            Console.WriteLine("El maximo es {0:#,###.00} el minimo es {1:#,###.00} y el promedio de los 5 numeros es {2:#,###.00}", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}
