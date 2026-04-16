// Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
namespace HW_03_Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            Console.WriteLine(number % 2 == 0? "Yes": "No");
        }
    }
}
