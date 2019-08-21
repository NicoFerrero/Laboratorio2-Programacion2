using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this._color = color;
            this.SetTinta(tinta);
        }

        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta > 0 && tinta < 101)
            {
                this._tinta = tinta;
            }
            else
            {
                this._tinta = 0;
            }
        }

        public void Recargar()
        {
            this._tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = "";

            if(this._tinta >= gasto)
            {
                this._tinta = (short)(this._tinta - gasto);
                pudoPintar = true;
                Console.ForegroundColor = this.GetColor();
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                Console.ForegroundColor = this.GetColor();
                for(int i = 0; i < this._tinta; i++)
                {
                    dibujo += "*";
                }
                this._tinta = 0;
            }

            return pudoPintar;
        }
    }
}
