using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rslforms
{
    public abstract class ShapeBase
    {
        public string Name { get; }

        protected ShapeBase(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public string GetInfo() =>
         $"{Name}: площадь = {Area():F2}, периметр = {Perimeter():F2}";
    }
    public class CircleA : ShapeBase
    {
        public double Radius { get; }
        public CircleA(double radius) : base("Круг")
       {
            Radius = radius;
       }
        public override double Area() => Math.PI * Radius * Radius;
        public override double Perimeter() => 2 * Math.PI * Radius;
    }
    public class RectangleA : ShapeBase

    {
        public double Width { get; }
        public double Height { get; }

        public RectangleA(double width, double height) : base("Прямоугольник")

        {
            Width = width;
            Height = height;
        }
        public override double Area() => Width * Height;
        public override double Perimeter() => 2 * (Width + Height);
    }
}