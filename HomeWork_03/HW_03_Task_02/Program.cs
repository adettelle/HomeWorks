// Вводятся три числа. Вывести большее их них.
namespace HW_03_Task_02
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

            double max = firstNumber > secondNumber ? firstNumber : secondNumber;

            if (max < thirdNumber)
            {
                max = thirdNumber;
            }
            Console.WriteLine($"max is {max}");
        }
    }
}
