using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float valorHora;
            int antiguedad;
            int horasMes;
            bool control;
            string seguir;
            double neto;
            double bruto;
            double descuento;

            Console.Title = "Ejercicio Nro 08";

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su valor hora");
                valorHora = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su antigüedad");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes");
                horasMes = int.Parse(Console.ReadLine());

                bruto = (valorHora * horasMes) + (antiguedad * 150);
                neto = bruto * 0.87;
                descuento = bruto - neto;

                Console.WriteLine("Nombre: {0} Antigüedad: {1} Valor Hora: {2:#,###.00} Total a cobrar bruto: {3:#,###.00} Total de descuento: {4:#,###.00} Total a cobrar neto: {5:#,###.00}", nombre, antiguedad, valorHora, bruto, descuento, neto);

                Console.WriteLine("Desea cargar otro empleado?");
                seguir = Console.ReadLine();
                if(seguir == "si")
                {
                    control = true;
                }
                else
                {
                    control = false;
                }

            } while (control);

            Console.ReadKey();
        }
    }
}
