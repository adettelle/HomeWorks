// Вводятся два числа. Обменять их местами, не используя третью переменную.
namespace HW_02_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine()); // 3
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine()); // 5
            Console.WriteLine($"a = {a}, b = {b}");

            a = a + b; // a = 8
            b = a - b; // b = 3
            a = a - b; // a = 5

            Console.WriteLine($"Numbers after change: a = {a}, b = {b}");
        }
    }
}
