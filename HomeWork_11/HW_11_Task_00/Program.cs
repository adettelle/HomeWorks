using System.Drawing;

namespace HW_11_Task_00
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricShape[] shapes = new GeometricShape[]
            {
                new Triangle(3, 4, 5),
                new Triangle(3, 5, 6),
                new Rectangle(4, 6),
                new Rectangle(3, 3)
            };
            // Демонстрация полиморфизма
            foreach (var shape in shapes)
                shape.PrintInfo();
        }
    }

    // Абстрактный класс "Геометрическая фигура"
    public abstract class GeometricShape
    {
        // Абстрактное свойство для имени фигуры
        public abstract string Name { get; }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        // Обычный (не абстрактный) метод
        public void PrintInfo()
        {
            Console.WriteLine($"Figure: {Name}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
            Console.WriteLine();
        }
    }

    public class Triangle : GeometricShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a; SideB = b; SideC = c;
        }
        public override string Name => "Triangle";
        public override double CalculateArea()
        {
            double p = SideA + SideB + SideC;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    public class Rectangle : GeometricShape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }
        public override string Name => "Rectangle";
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override double CalculatePerimeter()
        {
            return (Height + Width) * 2;
        }
    }
}
