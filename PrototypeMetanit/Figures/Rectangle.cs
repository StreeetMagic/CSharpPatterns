using System;

namespace PrototypeMetanit
{
    internal class Rectangle: IFigure
    {
        private readonly int _width;
        readonly int _height;
        public Rectangle(int w, int h)
        {
            _width = w;
            _height = h;
        }
 
        public IFigure Clone()
        {
            return new Rectangle(this._width, this._height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", _height, _width);
        }
    }
}