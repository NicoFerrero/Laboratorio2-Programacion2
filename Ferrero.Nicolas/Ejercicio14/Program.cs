using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double operador1;
            double operador2;
            double area;
            int op;
            bool esEntero;

            Console.Title = "Ejercicio Nro 14";

            do
            {
                Console.Clear();
                Console.WriteLine("1- Area del cuadrado");
                Console.WriteLine("2- Area del triangulo");
                Console.WriteLine("3- Area del circulo");
                Console.WriteLine("4- Salir");
                Console.Write("Que area desea calcular: ");
                esEntero = int.TryParse(Console.ReadLine(), out op);
                while(esEntero != true)
                {
                    Console.Clear();
                    Console.WriteLine("Error. La opcion debe ser un numero entero");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("1- Area del cuadrado");
                    Console.WriteLine("2- Area del triangulo");
                    Console.WriteLine("3- Area del circulo");
                    Console.WriteLine("4- Salir");
                    Console.Write("Que area desea calcular: ");
                    esEntero = int.TryParse(Console.ReadLine(), out op);
                }
                switch(op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese el valor de un lado del cuadrado: ");
                        operador1 = double.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCuadrado(operador1);
                        Console.Clear();
                        Console.WriteLine("El area del cuadrado de lado {0} es: {1:#,###.00}", operador1, area);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese el valor de la altura del triangulo: ");
                        operador1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el valor de la base del triangulo: ");
                        operador2 = double.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularTriangulo(operador2,operador1);
                        Console.Clear();
                        Console.WriteLine("El area del triangulo de base {0} y altura {1} es: {2:#,###.00}", operador2, operador1, area);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese el valor del radio del circulo: ");
                        operador1 = double.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCirculo(operador1);
                        Console.Clear();
                        Console.WriteLine("El area del circulo de radio {0} es: {1:#,###.00}", operador1, area);
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Esta saliendo de la aplicaion");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Ingreso una opcion no valida");
                        Console.ReadKey();
                        break;
                }

            } while (op != 4);
        }
    }
}
