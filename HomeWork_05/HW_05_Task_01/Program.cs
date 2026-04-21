// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
// Определить, каких чисел больше – четных или нечетных
namespace HW_05_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 100;
            int[] array = new int[n];
            Random rnd = new Random();
            int countEvent = 0;// чётные
            int countOdd = 0;  // нечётные

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                if (array[i] % 2 == 0)
                {
                    countEvent++;
                } else
                {
                    countOdd++;
                }
            }
            Console.WriteLine($"number of even numbers is {countEvent}; number of odd numbers is {countOdd}");
        }
    }
}
