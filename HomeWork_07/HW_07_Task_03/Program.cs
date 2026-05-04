// Напишите метод PrintNumbers, который выводит на экран числа из массива.
// У метода должен быть необязательный параметр reverse, который по умолчанию равен false.
// Если reverse равен true, числа выводятся в обратном порядке.
// Пример вызова:
// int[] numbers = { 1, 2, 3, 4, 5 };
// PrintNumbers(numbers); // Вывод: 1 2 3 4 5
// PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
namespace HW_07_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers); // Вывод: 1 2 3 4 5
            PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
        }

        static void PrintNumbers(int[] nums, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
                
            } else
            {
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{nums[i]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
