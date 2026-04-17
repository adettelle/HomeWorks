// Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
namespace HW_04_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Если n>=21, то для хранения значения уже не хватит целочисленных типов,
            // существующих в C#. 
            // Поэтому можно при вводе делать проверку и предупреждать пользователя,
            // если вычислить факториал не удастся.
            int num;
            Console.Write("Enter a positive number below 21: ");
            do num = Convert.ToInt32(Console.ReadLine());
            while (num < 0 || num >= 21);

            int factorial = 1;
            
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial is {factorial}");
        }
    }
}
