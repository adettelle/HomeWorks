/*
Вводится длина трубы в метрах. Округлить длину до целых в большую сторону. Например, 
17.0  -> 17; 17.3  -> 18; 17.7  -> 18;
*/
namespace HW_02_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length in meters: ");
            double len = Convert.ToDouble(Console.ReadLine());
            int roundedLen =  (int)Math.Ceiling(len); 

            Console.WriteLine($"Rounded length is {roundedLen}");
            Console.ReadKey();
        }
    }
}
