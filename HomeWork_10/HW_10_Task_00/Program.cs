namespace HW_10_Task_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Демонстрация наследования и переопределения методов
            Triangle regularTriangle = new Triangle(5, 5, 6);
            regularTriangle.PrintInfo();

            Console.WriteLine();

            RectangleTriangle rectTriangle = new RectangleTriangle(3, 4);
            rectTriangle.PrintInfo();
            Console.WriteLine($"Is triangle pythagorean? {rectTriangle.IsPythagorean}");
            Console.WriteLine($"Perimeter: {rectTriangle.Perimeter:F2}");

            Console.WriteLine("\n--- Upcasting и Downcasting ---");

            // 2. Upcasting - приведение к базовому типу
            Triangle triangleUpcast = rectTriangle; // Неявное приведение
            Console.WriteLine("\nAfter upcasting");
            triangleUpcast.PrintInfo();

            // Вызывается переопределенный метод!
            // Console.WriteLine(triangleUpcast.IsPythagorean); Ошибка компиляции. У Triangle нет IsPythagorean

            // 3. Downcasting - приведение к производному типу
            if (triangleUpcast is RectangleTriangle)
            {
                RectangleTriangle triangleDowncast = (RectangleTriangle)triangleUpcast; // Явное приведение
                Console.WriteLine("\nAfer downcasting:");
                triangleDowncast.PrintInfo();

                // Альтернативный безопасный способ с as
                var triangleAs = triangleUpcast as RectangleTriangle;
                if (triangleAs != null)
                {
                    Console.WriteLine("\nAfter downcasting with as:");
                    triangleAs.PrintInfo();

                }
            }

        }
    }

    // Базовый класс
    public class Triangle
    {
        protected double a, b, c; // Стороны треугольника

        // Конструктор базового класса
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA; b = sideB; c = sideC;
        }

        // Виртуальный метод для вычисления площади
        //  virtual метод/свойство может быть переопределен в дочернем классe
        public virtual double CalculateArea()
        {
            // Формула Герона
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        // Метод для вывода информации
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Triangle with sides: {a:F2}, {b:F2}, {c:F2}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }
    }

    // Класс-наследник - прямоугольный треугольник
    public class RectangleTriangle : Triangle
    {
        // Конструктор через катеты
        public RectangleTriangle(double catetus1, double catetus2)
            : base (catetus1, catetus2, Math.Sqrt(catetus2 * catetus1 + catetus2 * catetus2))
        { }

        // Переопределяем метод расчета площади (проще для прямоугольного треугольника)
        public override double CalculateArea()
        {
            // Площадь прямоугольного треугольника = (катет1 * катет2) / 2
            return (a * b) / 2;
        }

        // Переопределяем вывод информации
        public override void PrintInfo()
        {
            Console.WriteLine($"Rectangle triangle with catetus: {a:F2}, {b:F2} " +
                $"and hypotenuse {c:F2}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }

        // Уникальное свойство - может ли треугольник быть пифагоровым (целочисленные стороны)
        // Имеет смысл только для прямоугольных треугольников
        // это свойство, а не метод класса!
        public bool IsPythagorean
        {
            get
            {
                // Проверяем, являются ли все стороны целыми числами
                return a % 1 == 0 && b % 1 == 0 && c % 1 == 0;
            }
        }

        // это свойство, а не метод класса!
        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }
    }
}
