// Напишите метод FindMax, который принимает переменное количество чисел
// и возвращает максимальное значение.
// Используйте ключевое слово params.
// Пример вызова:
// int maxNumber = FindMax(10, 25, 5, 30, 15);
// Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30
namespace HW_07_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30
        }

        static int FindMax(params int[] nums)
        {
            return nums.Max();
        }
    }
}
