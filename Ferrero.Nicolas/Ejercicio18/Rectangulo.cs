using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float _area;
        private float _perimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Punto vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            Punto vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());

            this._vertice1 = vertice1;
            this._vertice2 = vertice2;
            this._vertice3 = vertice3;
            this._vertice4 = vertice4;
            
            int lado = (Math.Abs(this._vertice3.GetX())) - (Math.Abs(this._vertice1.GetX()));
            int altura = (Math.Abs(this._vertice3.GetY())) - (Math.Abs(this._vertice1.GetY()));

            this._area = lado * altura;
            this._perimetro = (lado + altura) * 2;
        }

        public float GetArea()
        {
            return this._area;
        }

        public float GetPerimetro()
        {
            return this._perimetro;
        }

        public static void Mostrar(Rectangulo rectangulo)
        {
            Console.WriteLine("El vertice 1 es: ({0};{1})", rectangulo._vertice1.GetX(), rectangulo._vertice1.GetY());
            Console.WriteLine("El vertice 3 es: ({0};{1})", rectangulo._vertice3.GetX(), rectangulo._vertice3.GetY());
            Console.WriteLine("El area del rectangulo es: {0}", rectangulo.GetArea());
            Console.WriteLine("El perimetro del rectangulo es: {0}", rectangulo.GetPerimetro());
        }
    }
}
