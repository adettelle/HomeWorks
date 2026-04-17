// Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
// n=3; 1/1 + 1/2 + 1/3; res = 1.833
// n=4; 1/1 + 1/2 + 1/3 + 1/4; res = 2.083
namespace HW_04_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a positive number: ");
            do num = Convert.ToInt32(Console.ReadLine());
            while (num <= 0);

            double res = 0;

            for (int i = 1; i <= num; i++)
            {
                res += 1.0 / i;
            }

            Console.WriteLine($"result is {res:F3}");
        }
    }
}
