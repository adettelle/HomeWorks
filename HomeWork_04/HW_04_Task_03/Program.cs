// Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
namespace HW_04_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter base (a positive number): ");
            do a = Convert.ToInt32(Console.ReadLine());
            while (a <= 0);

            int b;
            Console.Write("Enter power (a positive number): ");
            do b = Convert.ToInt32(Console.ReadLine());
            while (b <= 0);
            
            double res = a;

            for (int i = 1; i < b; i++)
            {
                res *= a;
            }

            Console.WriteLine($"result is {res}");
        }
    }
}
