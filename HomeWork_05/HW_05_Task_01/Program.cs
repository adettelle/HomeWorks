// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
// Определить, каких чисел больше – четных или нечетных
namespace HW_05_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int countEven = 0;// чётные

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                // Console.Write("{0,4}", array[i]);
                if (array[i] % 2 == 0) countEven++;
            }
            // Console.WriteLine();
            Console.WriteLine($"Array: [{string.Join(", ", array)}]");
            // два тернарных оператора, один внутри другого
            //Console.WriteLine(countEven > n-countEven? "There are more even numbers than odd numbers" :
            //    countEven < n-countEven ? "There are more odd numbers than even numbers" : "The number of even and odd numbers is equal");
            if (countEven > n - countEven)
            {
                Console.WriteLine("There are more even numbers than odd numbers");
            }
            else if (countEven < n - countEven)
            {
                Console.WriteLine("There are more odd numbers than even numbers");
            }
            else
            {
                Console.WriteLine("The number of even and odd numbers is equal");
            }
        }
    }
}
