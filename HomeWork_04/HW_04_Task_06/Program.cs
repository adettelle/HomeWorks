// Вводится n. Определить, является ли оно степенью 2-ки?
// num = 8; power = 3
// num = 32; power = 5
namespace HW_04_Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.Write("number must be positive");
                return;
            }

            int power = 0;
            int temp = num;

            while (temp % 2 == 0)
            {
                power++;
                temp /= 2;
            }
            if (temp == 0)
            {
                Console.WriteLine($"number is not a power of two");

            }
            else if (temp == 1)
            {
                Console.WriteLine($"number is a power of two: 2^{power} is {num}");
            }
        }
    }
}
