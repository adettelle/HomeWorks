// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
// Определить, каких чисел больше – четных или нечетных
namespace HW_05_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 100;
            int[] array = new int[n];
            Random rnd = new Random();
            int countEven = 0;// чётные

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                if (array[i] % 2 == 0) countEven++;
            }
            Console.WriteLine(countEven > n-countEven? "There are more even numbers than odd numbers" :
                countEven < n-countEven ? "There are more odd numbers than even numbers" : "The number of even and odd numbers is equal");
        }
    }
}
