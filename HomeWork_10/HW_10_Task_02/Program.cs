namespace HW_10_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // приводим дочерние классы к базовому классу: Это Upcasting. Он выполняется автоматически, без явного приведения типа.
            // Создаётся объект Triangle, но ссылка на него имеет тип Shape.
            Shape t1 = new Triangle(3, 4, 5);
            // Создаётся объект Circle, но ссылка на него тоже имеет тип Shape.
            Shape c1 = new Circle(2);

            // В массив помещаются объекты разных классов, но все они наследуются от Shape.
            // Это ещё одно преимущество Upcasting: мы можем хранить объекты разных дочерних классов в одной коллекции базового типа.
            // вызов Area() - есть полиморфизм — один и тот же вызов метода работает по-разному в зависимости от реального типа объекта.
            Shape[] shapes = { t1, c1 };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.Info()} \nArea: {shape.Area():F2}");

                // Downcasting с проверкой типа
                if (shape is Circle)
                {
                    Circle circle = (Circle)shape; 
                    Console.WriteLine($"IN DOWNCASTING: Circle radius: {circle.Radius}");
                }
                //В современном C# можно написать короче:
                else if (shape is Triangle triangle)
                {
                    // Triangle triangle = (Triangle)shape;
                    Console.WriteLine($"IN DOWNCASTING: Triangle side A: {triangle.SideA}");
                }
            }

            // Console.WriteLine($"Triangle area: {t1.Area():F2}");
            // Console.WriteLine($"Circle area: {c1.Area():F2}");
        }
    }

    public abstract class Shape
    {
        // Абстрактный метод для вычисления площади
        public abstract double Area();
        public abstract string Info();
    }

    public class Triangle : Shape
    {
        public double SideA {  get; set; }
        public double SideB {  get; set; }
        public double SideC {  get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Реализация вычисления площади по формуле Герона
        public override double Area() 
        { 
            double p = SideA + SideB + SideC;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override string Info()
        {
            return $"Triangle with sides: {SideA}, {SideB}, {SideC}";
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string Info()
        {
            return $"Circle with radius: {Radius}";
        }
    }
}
