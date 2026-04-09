namespace HW_02_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Длина отрезка задана в дюймах (1 дюйм = 2,54 см). 
             * Перевести значение длины в метрическую систему, то есть выразить ее в метрах, 
             * сантиметрах и миллиметрах. Например, 21 дюйм = 0 м 53 см 3,4 мм
             * 9.5 inch = 24.13 cm = 2m 4cm 1mm
             */

            double len_inch = Convert.ToDouble(Console.ReadLine());
            double len_mm = Convert.ToDouble(len_inch * 2.54 * 10);
            Console.WriteLine("{0} inches is {1}mm", len_inch, len_mm);

            int mm = Convert.ToInt32(len_mm % 10);
            int cm = Convert.ToInt32((len_mm / 10) % 10);
            int m = Convert.ToInt32(len_mm / 100);


            Console.WriteLine("{0} inches is {1}m {2}cm {3}mm", len_inch, m, cm, mm);
        }
    }
}
