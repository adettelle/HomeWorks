/*
* Вводятся три числа. Обменять их местами циклически. 
* Например, вводятся a=1, b=2, c=3. 
* После обмена в переменных должны оказаться значения a=3, b=1, c=2.
*/

namespace HW_02_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers are: a={a}, b={b}, c={c}");

            int t;
            t = c; // t = 3
            c = b; // c = 2
            b = a; // b = 1
            a = t; // a = 3

            Console.WriteLine("Nubers after change are: a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
