// матрицу A(m,n) заполнить натуральными числами от 1 до n*m по спирали,
// начинающейся в левом верхнем углу и закрученной по часовой стрелке
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
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = m - 1;
            int num = 1;

            while (top <= bottom && left <= right)
            {
                // to the right
                for (int i = left; i <= right; i++) array[top, i] = num++;
                top++;
                // to the bottom
                for (int i = top; i <= bottom; i++) array[i, right] = num++;
                right--;
                // to the left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) array[bottom, i] = num++;
                    bottom--;
                }
                // to the top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) array[i, left] = num++;
                    left++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array[i, j], 3}");
                }
                Console.WriteLine();
            }
        }
    }
}
