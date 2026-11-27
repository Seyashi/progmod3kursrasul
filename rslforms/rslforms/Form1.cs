using System;
using System.Windows.Forms;

namespace rslforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Log(string text) =>
            txtOutput.AppendText(text + Environment.NewLine);

        // =========================================================
        // 1. АБСТРАКЦИЯ (абстрактный класс ShapeBase)
        // =========================================================

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            double r = (double)nudRadius.Value;
            double w = (double)nudWidth.Value;
            double h = (double)nudHeight.Value;

            ShapeBase[] shapes = { new CircleA(r), new RectangleA(w, h) };

            Log("=== Абстрактный класс ShapeBase ===");
            foreach (ShapeBase s in shapes)
                Log(s.GetInfo());

            Log("");
        }

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

        // =========================================================
        // 2. ИНТЕРФЕЙС (IShape, IScalable)
        // =========================================================

        private static string Describe(IShape s) =>
            $"{s.Name}: площадь = {s.Area():F2}, периметр = {s.Perimeter():F2}";

        private void btnInterface_Click(object sender, EventArgs e)
        {
            double r = (double)nudRadius.Value;
            double w = (double)nudWidth.Value;
            double h = (double)nudHeight.Value;

            IShape[] shapes = { new Circlel(r), new Rectanglel(w, h) };

            Log("=== Интерфейс IShape ===");
            foreach (IShape s in shapes)
                Log(Describe(s));

            Log("--- Проверка способности IScalable (Scale(2)) ---");
            foreach (IShape s in shapes)
            {
                if (s is IScalable scalable)
                {
                    scalable.Scale(2);
                    Log("После масштабирования: " + Describe(s));
                }
                else
                {
                    Log($"{s.Name}: масштабирование не поддерживается");
                }
            }

            Log("");
        }

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

        // =========================================================
        // 3. ОЧИСТКА
        // =========================================================

        private void btnClear_Click(object sender, EventArgs e) =>
            txtOutput.Clear();
    }
}