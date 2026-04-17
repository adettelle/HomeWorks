// Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
namespace HW_04_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("enter a number: ");
            do a = Convert.ToInt32(Console.ReadLine());
            while (a < 20 || a > 60);

            Console.WriteLine($"number is {a}");
        }
    }
}
