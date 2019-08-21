using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int _x;
        private int _y;

        public Punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public int GetX()
        {
            return this._x;
        }

        public int GetY()
        {
            return this._y;
        }
    }
}
