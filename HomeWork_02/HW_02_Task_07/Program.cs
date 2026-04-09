namespace HW_02_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вводятся два числа. Обменять их местами, не используя третью переменную.
             */
            int a = Convert.ToInt32(Console.ReadLine()); // 3
            int b = Convert.ToInt32(Console.ReadLine()); // 5
            Console.WriteLine("a = {0}, b = {1}", a, b);

            a = a + b; // a = 8
            b = a - b; // b = 3
            a = a - b; // a = 5

            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
