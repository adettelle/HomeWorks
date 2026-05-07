// Два треугольника заданы длинами своих сторон.
// Определите, площадь какого из них больше
// (создайте метод Square для вычисления площади треугольника по длинам его сторон).
// Для решения задачи можно использовать формулу Герона.
// 4 5 6; 5 6 7; 7 8 9
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Security.Principal;

namespace HW_07_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of triangles: ");
            int count;

            while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
            {
                Console.Write("Enter a positive number");
            }

            double[][] triangles = new double[count][];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter the three sides of the triangle {i + 1} separated by a space: ");
                while (true)
                {
                    string? input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Empty input, try again:");
                        continue;
                    }
                    string[] triangle = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (triangle.Length != 3)
                    {
                        Console.WriteLine("Please enter exactly 3 numbers:");
                        continue;
                    }

                    double[] sides = new double[3];
                    bool valid = true;

                    for (int j = 0; j < 3; j++)
                    {
                        if (!double.TryParse(triangle[j], out sides[j]))
                        {
                            Console.WriteLine($"Invalid number: {triangle[j]}");
                            valid = false;
                            break;
                        }
                    }
                    if (!valid) continue;
                    triangles[i] = sides;
                    break;
                }
            }
            Console.WriteLine(triangles);

            double[] areas = new double[triangles.Length];

            for (int i = 0; i < triangles.Length; i++)
            {
                double area = Square(triangles[i]);
                Console.WriteLine($"Square of trinagle {i + 1} is {area:F2}");
                areas[i] = area;
            }

            Console.WriteLine($"Maximun area is {areas.Max():F2}");
        }

        static double Square(double[] sides)
        {
            double p = 0;
            foreach (double side in sides)
            {
                p += side;
            }
            p = p / 2;

            double s = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));

            return s;
        }
    }
}
