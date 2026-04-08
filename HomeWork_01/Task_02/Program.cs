namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10 + a++;
            Console.WriteLine(b);
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
