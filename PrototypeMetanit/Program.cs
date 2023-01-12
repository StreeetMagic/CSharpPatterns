using System;

namespace PrototypeMetanit
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IFigure figure = new Rectangle(30,40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
 
            figure = new Circle(30);
            clonedFigure=figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
 
            Console.Read();
        }
    }
}