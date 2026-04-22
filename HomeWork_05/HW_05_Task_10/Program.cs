// Клеточное поле размером n*n состоит из 0 ("ноликов") и 1 ("крестиков").
// Проверить, выиграли ли "крестики"?
// "крестики" выиграли, если есть горизонталь, вертикаль или диагональ единиц.
namespace HW_05_Task_10
{
    internal class Program
    {
        static void PrintArray(int[,] array)
        {
            int n = array.GetLength(0);

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{array[r, c],2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static bool HasWin(int[,] array)
        {
            int n = array.GetLength(0);

            for (int r = 0; r < n; r++)
            {
                bool flagHor = true;
                bool flagVert = true;

                for (int c = 0; c < n; c++)
                {
                    if (array[r, c] != 1) flagHor = false;
                    if (array[c, r] != 1) flagVert = false;
                }
                if (flagHor == true)
                {
                    Console.WriteLine($"Horisontal flag is {flagHor}");
                    return true;
                }
                if (flagVert == true)
                {
                    Console.WriteLine($"Vertical flag is {flagVert}");
                    return true;
                }
            }

            bool flagDiag1 = true;
            bool flagDiag2 = true;

            for (int r = 0; r < n; r++)
            {

                if (array[r, r] != 1) { flagDiag1 = false; }
                if (array[r, n - r - 1] != 1) { flagDiag2 = false; }

            }
            if (flagDiag1 == true)
            {
                Console.WriteLine($"Diagonal flag 1 is {flagDiag1}");
                return true;
            }
            if (flagDiag2 == true)
            {
                Console.WriteLine($"Diagonal flag 2 is {flagDiag2}");
                return true;
            }
            // return flagDiag1 || flagDiag2;
            return false;
        }

        static void Test(int[,] array, string name)
        {
            Console.WriteLine($"------ {name} ------");
            PrintArray(array);

            bool win = HasWin(array);
            Console.WriteLine($"Win: {win}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            const int n = 4;

            Random rnd = new Random();
            int[,] array = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    array[r, c] = rnd.Next(0, 2);
                }
            }

            int[,] array1 = new int[n, n]
            {
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 1, 1, 1, 1 },
                { 0, 0, 0, 0 }
            };

            int[,] array2 = new int[n, n]
            {
                { 0, 1, 0, 0 },
                { 0, 1, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 1, 0, 0 }
            };

            int[,] array3 = new int[n, n]
            {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 1, 1, 1 },
                { 0, 0, 0, 1 }
            };

            int[,] array4 = new int[n, n]
            {
                { 0, 0, 0, 1 },
                { 0, 0, 1, 0 },
                { 1, 1, 1, 0 },
                { 1, 0, 0, 0 }
            };

            Test(array, "random array");
            Test(array1, "array with horizontal win");
            Test(array2, "array with vertical win");
            Test(array3, "array with diagonal 1 win");
            Test(array4, "array with diagonal 2 win");

        }
    }
}