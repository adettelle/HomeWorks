// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10]
// Перевернуть массив, то есть переставить элементы в обратном порядке.
namespace HW_05_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            int[] arrayReversed = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
                arrayReversed[n - 1 - i] = array[i];
            }
            // Array.Reverse(array);
            Console.WriteLine($"initial  array is: {string.Join(", ", array)}");
            Console.WriteLine($"reversed array is: {string.Join(", ", arrayReversed)}");
        }
    }
}
