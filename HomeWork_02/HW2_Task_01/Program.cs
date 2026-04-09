namespace HW2_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вводятся три числа. Обменять их местами циклически. 
             * Например, вводятся a=1, b=2, c=3. 
             * После обмена в переменных должны оказаться значения a=3, b=1, c=2.
             */
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            int t;
            t = a; // t = 1
            a = b; // a = 2
            b = c; // b = 3
            c = t; // c = 1

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}
