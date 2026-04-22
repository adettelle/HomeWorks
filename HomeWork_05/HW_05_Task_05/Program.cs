// Сформировать одномерный массив из 10 случайных чисел из диапазона [-50, 50]
// Первые 5 элементов упорядочить по возрастанию, вторые 5 - по убыванию.
namespace HW_05_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 51);
            }

            Console.WriteLine($"   initial array is: {string.Join(", ", array)}");

            for (int i = 0; i < n/2-1; i++)
            {
                for (int j = i+1; j < n/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp; 
                    }
                }
            }

            for (int i = n/2; i < n - 1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            // Второй вариант - использование методов Sort и Reverse
            // Array.Sort(array, 0, 5); // Сортировка первых 5 по возрастанию
            // Array.Sort(array, 5, 5); // Сортировка вторых 5
            // Array.Reverse(array, 5, 5); // Разворот вторых 5 для убывания

            Console.WriteLine($"array after sort is: {string.Join(", ", array)}");
            //Console.WriteLine($"reversed array is: {string.Join(", ", arrayReversed)}");
        }
    }
}
