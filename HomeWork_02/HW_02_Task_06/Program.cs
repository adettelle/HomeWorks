namespace HW_02_Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вводится длина трубы в метрах. Округлить длину до 0,5. Например, 
             * 17.01 -> 17; 17.099 -> 17; 17.1 -> 17; 17.2 -> 17; 17.3 -> 17.5;
             * 17.51 -> 17.5; 17.6 -> 17.5; 17.9 -> 18; 18 -> 18
             * Примечание. Не использовать условные операторы. 
             * Разрешено использовать только математические операции и методы библиотеки Math.
             */
            const double step = 0.5;
            double len = Convert.ToDouble(Console.ReadLine());
            double len_out = Math.Round(len / step) * step;
             Console.WriteLine("input len is {0}, output len is {1}", len, len_out);
        }
    }
}
