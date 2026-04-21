// Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20].
// Определить количество положительных, отрицательных и равных нулю элементов
namespace HW_05_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int countPositive = 0;
            int countNegative = 0;
            int countNull = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                if (array[i] == 0) countNull++;
                else if (array[i] < 0) countNegative++;
                else countPositive++;
            }
            Console.WriteLine($"array is {string.Join(", ", array)}");

            Console.WriteLine($"number of positive numbers is {countPositive}");
            Console.WriteLine($"number of negative numbers is {countNegative}");
            Console.WriteLine($"number of null numbers is {countNull}");

        }
    }
}
