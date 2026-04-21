// Сформировать двумерный массив из 10 строк и 5 столбцов.
// Заполнить его случайными числами из диапазона [0, 10]
// Определить максимальный элемент в каждой строке
namespace HW_05_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int rows = 10;
            Random rnd = new Random();
            int[] array = new int[n];

            for (int j = 0; j < rows; j++)
            {
                int max = 0;
                for (int i = 0; i < n; i++)
                {

                    array[i] = rnd.Next(0, 11);
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                }
                Console.WriteLine($"{string.Join(" ", array)}; max = {max}");

            }
        }
    }
}
