using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            //SetColor(color);
            //SetTinta(tinta);
            this._color = color;
            this._tinta = tinta;
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
            
            short resultado;
            
            if (tinta < 0)
            {
                resultado =(short)(_tinta - tinta);
                if (resultado < 0)
                {
                    this._tinta = 0;
                }
                else
                    this._tinta = resultado;
            }

            if (tinta >0)
            {
                resultado = (short)(_tinta + tinta);
                if (resultado > cantidadTintaMaxima)
                {
                    this._tinta = cantidadTintaMaxima;
                }
                else
                    this._tinta = resultado;
            }        
        }

        //public void SetColor(ConsoleColor color)
        //{
        //    this._color = color;
        //}

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool rta = true;
            string dibujoCaracter = "";

            if (this._tinta > 0)
            {
                
                for (int i = 0; i < gasto; i++)
                {
                    dibujoCaracter = dibujoCaracter + "*";
                }
                
                
            }
            if (this._tinta <= 0)
            {
                this._tinta = 0;
                rta = false;
            }

            dibujo = dibujoCaracter;
            return rta;
        }

        public static string Mostrar(Boligrafo b)
        {
            StringBuilder boligrafo = new StringBuilder();
            boligrafo.Append("Color ");
            boligrafo.Append(b.GetColor().ToString()+"  ");
            boligrafo.Append(b.GetTinta().ToString());

            return boligrafo.ToString();
        }
    }
}
