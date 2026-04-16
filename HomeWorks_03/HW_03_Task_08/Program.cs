// // Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.
namespace HW_03_Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number >= -10 && number <= 10)
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
