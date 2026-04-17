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
            Console.Write("enter a positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.Write("number must be positive");
                return;
            }

            int length = (int)Math.Floor(Math.Log10(num)) + 1;

            int power = length-1;
            int temp = num;
            int resNum = 0;

            for (int i = length; i >= 0; i--) 
            {
                int digit = temp % 10;
                resNum += digit * (int)Math.Pow(10, power);
                temp = temp / 10;
                power--;
            }

            Console.WriteLine($"mirrored number is {resNum}");

        }
    }
}
