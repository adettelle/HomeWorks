// матрицу A(m,n) заполнить натуральными числами от 1 до n*m по сирали,
// начинающейся в левом верхнем углу и 6закрученной по часовой стрелке
// 1  2  3  4  5
// 16 17 18 19 6
// 15 24 25 20 7
// 14 23 22 21 8
// 13 12 11 01 9
namespace HW_05_Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;

            int[,] array = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0, n * n + 1);
                    Console.Write($"{array[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
