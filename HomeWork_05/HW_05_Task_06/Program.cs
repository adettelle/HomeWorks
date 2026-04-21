// Сформировать двумерный массив вида
// 1 0 1 0 1
// 0 1 0 1 0
// 1 0 1 0 1
// 0 1 0 1 0
// 1 0 1 0 1
namespace HW_05_Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0) array[i, j] = 1;
                    else if (i % 2 == 0 && j % 2 == 0) array[i, j] = 1;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
