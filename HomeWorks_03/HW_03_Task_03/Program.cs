// Вводятся четыре числа. Вывести большее из них.
namespace HW_03_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            double fourthNumber = Convert.ToDouble(Console.ReadLine());

            // Вариант 1
            /*
             double max = firstNumber > secondNumber ? firstNumber : secondNumber;

             if (thirdNumber > max) max = thirdNumber;
             if (fourthNumber > max) max = fourthNumber;
            */

            //  Вариант 2
            double max = Math.Max(double.Max(firstNumber, secondNumber), double.Max(thirdNumber, fourthNumber));
            Console.WriteLine($"max is {max}");
        }
    }
}