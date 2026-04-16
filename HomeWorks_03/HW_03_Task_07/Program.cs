// Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
namespace HW_03_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if ((number > 9 && number < 100) || (number > -100 && number < -9))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
