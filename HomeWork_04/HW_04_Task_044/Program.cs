// Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math
// a = 10; b = -3; res = 0.001
namespace HW_04_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("enter a positive number: ");
            do a = Convert.ToInt32(Console.ReadLine());
            while (a <= 0);

            int b;
            Console.Write("enter a negative number: ");
            do b = Convert.ToInt32(Console.ReadLine());
            while (b >= 0);

            double res = 1;

            for (int i = 0; i < -b; i++) 
            {
                res *= a;
            }

            res = 1.0 / res;

            Console.WriteLine($"result is {res:F3}");
        }
    }
}
