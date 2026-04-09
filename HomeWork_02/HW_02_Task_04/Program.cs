namespace HW_02_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.
             * 1234 -> 1432
             */

            int n_in = Convert.ToInt32(Console.ReadLine());

            int a = n_in % 10;         // 4
            int b = (n_in / 10) % 10;  // 3
            int c = (n_in / 100) % 10; // 2
            int d = n_in / 1000;       // 1
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);

            int n_out = d * 1000 + a * 100 + b * 10 + c;

            Console.WriteLine("input number is {0}, otput number is {1}", n_in, n_out);
        }
    }
}
