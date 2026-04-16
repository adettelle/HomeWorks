// Вводятся три разных числа. Вывести медиану.
// Медиана - это число, которое в отсортированном ряду стоит "посередине".
// Например, для чисел 3, 0, 9 медианой будет 3.
using System.Diagnostics.Metrics;

namespace HW_03_Task_04
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

            // double min = (firstNumber <  secondNumber) ? firstNumber : secondNumber; 
            /*
            double change;
            if (firstNumber > secondNumber)
            {
                change = firstNumber;
                firstNumber = secondNumber;
                secondNumber = change;
            }
            if (secondNumber > thirdNumber)
            {
                change = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = change;
            }
            if (firstNumber > secondNumber)
            {
                change = firstNumber;
                firstNumber = secondNumber;
                secondNumber = change;
            }
            */
            double median =
                firstNumber + secondNumber + thirdNumber
                - Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber)) 
                - Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
            Console.WriteLine($"Median number is {secondNumber}");
        }
    }
}


