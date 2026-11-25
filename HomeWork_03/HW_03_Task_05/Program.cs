// Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
namespace HW_03_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            //if (number % 10 == 0) Console.WriteLine("Yes");
            //else Console.WriteLine("No");
            Console.WriteLine(number % 10 == 0? "Yes": "No");
        }
    }
}
