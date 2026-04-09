namespace HW_02_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вводится длина трубы в метрах. Округлить длину до целых в большую сторону. Например, 
             * 17.0  -> 17; 17.3  -> 18; 17.7  -> 18;
             */
            double len = Convert.ToDouble(Console.ReadLine());
            int len_round = Convert.ToInt32(Math.Ceiling(len));

            Console.WriteLine("length input is {0}, rounded len is {1}", len, len_round);
        }
    }
}
