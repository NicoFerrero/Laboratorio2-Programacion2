using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double resultado;
            bool esNumerico;
            bool esChar;
            char op;

            Console.Title = "Ejercicio Nro 15";

            do
            {
                Console.Clear();
                Console.WriteLine("+ (Suma)");
                Console.WriteLine("- (Resta)");
                Console.WriteLine("* (Multiplicacion)");
                Console.WriteLine("/ (Division)");
                Console.WriteLine("s (Salir)");
                Console.Write("Que operacion desea realizar: ");
                esChar = char.TryParse(Console.ReadLine(), out op);
                while(esChar != true)
                {
                    Console.Clear();
                    Console.WriteLine("Error. La opcion debe ser un caracter");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("+ (Suma)");
                    Console.WriteLine("- (Resta)");
                    Console.WriteLine("* (Multiplicacion)");
                    Console.WriteLine("/ (Division)");
                    Console.WriteLine("s (Salir)");
                    Console.Write("Que operacion desea realizar: ");
                    esChar = char.TryParse(Console.ReadLine(), out op);
                }

                while (op != 's' && op != 'S')
                {
                    Console.Write("Ingrese el primer operando: ");
                    esNumerico = double.TryParse(Console.ReadLine(), out numero1);
                    while(esNumerico != true)
                    {
                        Console.Clear();
                        Console.WriteLine("Error. El operando debe ser numerico");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ingrese el primer operando: ");
                        esNumerico = double.TryParse(Console.ReadLine(), out numero1);
                    }

                    Console.Write("Ingrese el segundo operando: ");
                    esNumerico = double.TryParse(Console.ReadLine(), out numero2);
                    while (esNumerico != true)
                    {
                        Console.Clear();
                        Console.WriteLine("Error. El operando debe ser numerico");
                        Console.ReadKey();
                        Console.Clear();
                        Console.Write("Ingrese el segundo operando: ");
                        esNumerico = double.TryParse(Console.ReadLine(), out numero2);
                    }

                    resultado = Calculadora.Calcular(numero1, numero2, op);
                    Calculadora.Mostrar(resultado);
                    break;
                } 

            } while (op != 's' && op != 'S');
        }
    }
}
