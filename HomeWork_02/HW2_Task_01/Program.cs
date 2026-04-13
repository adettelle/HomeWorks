/*
* Вводятся три числа. Обменять их местами циклически. 
* Например, вводятся a=1, b=2, c=3. 
* После обмена в переменных должны оказаться значения a=3, b=1, c=2.
*/

namespace HW2_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int t;
            t = a; // t = 1
            a = b; // a = 2
            b = c; // b = 3
            c = t; // c = 1

            Console.WriteLine("Nubers after change are: a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}
