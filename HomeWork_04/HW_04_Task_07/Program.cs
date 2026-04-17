// Вводится n. Определить количество цифр в числе
namespace HW_04_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int temp = num;

            while (temp > 10)
            {
                count++;
                temp = temp / 10;
            }
            count++;
            if (count == 1)
            {
                Console.WriteLine($"number of digits in the number is {count}");
            }
            else
            {
                Console.WriteLine($"number of digits in the number are {count}");
            }
        }
    }
}
