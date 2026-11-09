// Вводится число. Вывести его в зеркальном виде.
// Количество цифр в числе заранее неизвестно. Не использовать строки
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_04_Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = Math.Abs(num);
            int mirrored = 0;

            while (temp > 0)
            {
                mirrored = mirrored * 10 + temp % 10;
                temp /= 10;
            }
            if (num < 0)
            {
                mirrored = -mirrored;
            }

            Console.WriteLine($"mirrored number is {mirrored}");
        }
    }
}
