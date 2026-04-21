// Сформировать массив из 5 случайных чисел из диапазона [0, 10]
// Найти дла наибольших элемента
// [4, 8, 0, 9, 3] -> 8,9
// [5, 9, 1, 9, 3] -> 9,9
namespace HW_05_Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
            }
            Console.WriteLine($"initial array is: {string.Join(", ", array)}");

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            // Array.Sort(array);

            Console.WriteLine($"max numbers are: {array[n-2]}, {array[n-1]}");

        }
    }
}
