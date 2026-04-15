// Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».
namespace HW_03_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} > {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{firstNumber} < {secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} = {secondNumber}");
            }
        }
    }
}
