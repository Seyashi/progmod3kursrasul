using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rslforms
{
    public interface IShape
    {
        string Name { get; }
        double Area();
        double Perimeter();
    }
    public interface IScalable

    {
        void Scale(double factor);
    }
    public class Circlel : IShape, IScalable
    {
        public string Name => "Круг";
        public double Radius { get; private set; }

        public Circlel(double radius)
        {
            Radius = radius;
        }
        public double Area() => Math.PI * Radius * Radius;
        public double Perimeter() => 2 * Math.PI * Radius;
        public void Scale(double factor) => Radius *= factor;
    }
           public class Rectanglel : IShape
    { 

         public string Name => "Прямоугольник";
        public double Width { get; }
        public double Height { get; }

        public Rectanglel(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area() => Width * Height;
        public double Perimeter() => 2 * (Width + Height);
    }
}
