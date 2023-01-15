using System;

namespace PrototypeMetanit
{
    internal class Circle : IFigure
    {
        private readonly int _radius;
        public Circle(int r)
        {
            _radius = r;
        }
 
        public IFigure Clone()
        {
            return new Circle(this._radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", _radius);
        }
    }
}