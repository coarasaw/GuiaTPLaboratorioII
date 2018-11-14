using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometira
{
    public class Rectangulo
    {
        private float _perimetro;
        private float _area;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this._vertice1 = vertice1;
            this._vertice3 = vertice3;
        }

        public float Area()
        {
            int _base = Math.Abs(_vertice1.GetX() - _vertice3.GetX());
            int _alt = Math.Abs(_vertice1.GetY() - _vertice3.GetY());
            _area = (float)_base * _alt;
            return _area;
        }

        public float Perimetro()
        {
            int _base = Math.Abs(_vertice1.GetX() - _vertice3.GetX());
            int _alt = Math.Abs(_vertice1.GetY() - _vertice3.GetY());
            _perimetro = (float)((_base + _alt) * 2);
            return _perimetro;
        }

    }
}
