// Клеточное поле размером n*n состоит из 0 ("ноликов") и 1 ("крестиков").
// Проверить, выиграли ли "крестики"?
// "крестики" выиграли, если есть горизонталь, вертикаль или диагональ единиц.
namespace HW_05_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 4;
            Random rnd = new Random();
            int sumGorizont = 0;
            int sumVertical = 0;
            int sumDiagonal = 0;
            bool flagGor = false;
            bool flagVert = false;
            bool flagDiag = false;


            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write($"{array[i, j]} ");

                    sumGorizont += array[i, j];
                    if (sumGorizont == n * 1) flagGor = true;

                    //sumVertical += array[j, i];
                    //if (sumVertical == n * 1) flagVert = true;

                }
                sumGorizont = 0;
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++) // cols
            {
                Console.WriteLine($"Столбец {j}:");
                for (int i = 0; i < n; i++) // rows
                {
                    sumVertical += array[i, j];
                    if (sumVertical == n * 1) flagVert = true;
                }
                Console.WriteLine($"sumVertical {sumVertical}:");
                sumVertical = 0;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) sumDiagonal += array[i, j];
                    if (sumDiagonal == n * 1) flagDiag = true;
                }
            }

            Console.WriteLine($"flags are: gorizontal {flagGor}; vertical {flagVert}; diagonal {flagDiag}");
        }
    }
}
