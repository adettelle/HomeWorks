// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
// Найти и вывести значение максимального, минимального элементов и их индексы
namespace HW_05_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();


            array[0] = rnd.Next(0, 51);
            int maxNum = array[0];
            int maxIndex = 0;
            int minNum = array[0];
            int minIndex = 0;

            for (int i = 1; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                    maxIndex = i;
                }
                else if (array[i] < minNum)
                {
                    minNum = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"array is: {string.Join(", ", array)}");
            Console.WriteLine($"max number is {maxNum} max index is {maxIndex}");
            Console.WriteLine($"min number is {minNum} min index is {minIndex}");

        }
    }
}
