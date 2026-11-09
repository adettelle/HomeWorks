// Можно ли на прямоугольном участке застройки размером a * b метров
// разместить два дома размером в плане p * q и r * s метров?
// Дома можно располагать только параллельно сторонам участка.
// Дома могу стоять «вплотную» друг к другу.
namespace HW_03_Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the section: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of the section: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the first house: ");
            double h1Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of the first house: ");
            double h1Length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the second house: ");
            double h2Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of the second house: ");
            double h2Length = Convert.ToDouble(Console.ReadLine());

            // участок и два дома лежат горизонтально
            if (length >= (h1Length + h2Length))
            {
                if (width >= h2Width && width >= h1Width)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            // участок горизонтально первый дом горизонтально, второй вертикально
            else if (length >= (h1Length + h2Width))
            {
                if (width >= h1Width && width >= h2Length)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            // участок горизонтально первый дом вертикально, второй горизонтально
            else if (length >= (h1Width + h2Length))
            {
                if (width >= h1Length && width >= h2Width)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            // участок горизонтально оба дом вертикально
            else if (length >= (h1Width + h2Width))
            {
                if (width >= h1Length && width >= h2Length)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
