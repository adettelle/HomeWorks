// Застройщик построил n домов.
// Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом»,
// например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».
namespace HW_03_Task_010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string end = "";
            switch (number % 10)
            {
                case 1:
                    end = "";
                    break;
                case 2:
                case 3:
                case 4:
                    end = "а";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    end = "ов";
                    break;
                default:
                    end = "";
                    break;
            }
            Console.WriteLine($"Мы построили {number} дом{end}"); 

        }
    }
}
