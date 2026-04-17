// Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
namespace HW_04_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a positive number: ");
            do num = Convert.ToInt32(Console.ReadLine());
            while (num <= 0);

            int factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial is {factorial}");
        }
    }
}
