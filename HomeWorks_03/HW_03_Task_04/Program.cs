// Вводятся три разных числа. Вывести медиану.
// Медиана - это число, которое в отсортированном ряду стоит "посередине".
// Например, для чисел 3, 0, 9 медианой будет 3.
using System.Diagnostics.Metrics;

namespace HW_03_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // double min = (a <  b) ? a : b; 
            /*
            double change;
            if (a > b)
            {
                change = a;
                a = b;
                b = change;
            }
            if (b > c)
            {
                change = b;
                b = c;
                c = change;
            }
            if (a > b)
            {
                change = a;
                a = secondNubmber;
                b = change;
            }
            */
            double median = (a + b + c) - Math.Max(a, Math.Max(b, c)) - Math.Min(a, Math.Min(b, c));
            Console.WriteLine($"Median number is {median}");
        }
    }
}


