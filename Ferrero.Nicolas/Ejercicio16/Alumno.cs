using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private byte _notaFinal;
        public int legajo;
        public string apellido;
        public string nombre;

        public Alumno(string name, string lastName, int legajo)
        {
            this.nombre = name;
            this.apellido = lastName;
            this.legajo = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random notaFinal = new Random();

            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                //this._notaFinal = (byte)notaFinal.Next(4, 10);
                this._notaFinal = Convert.ToByte(notaFinal.Next(4, 10));
            }
            else
            {
                this._notaFinal = 0;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}", this.nombre);
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Legajo: {0}", this.legajo);
            Console.WriteLine("Nota 1: {0}", this._nota1);
            Console.WriteLine("Nota 2: {0}", this._nota2);
            if(this._notaFinal != 0)
            {
                Console.WriteLine("Nota Final: {0}", this._notaFinal);
            }
            else
            {
                Console.WriteLine("Nota Final: Alumno desaprobado");
            }
        }
    }
}
