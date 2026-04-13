/*
Длина отрезка задана в дюймах (1 дюйм = 2,54 см). 
Перевести значение длины в метрическую систему, то есть выразить ее в м, см, мм. 
Например: 21 дюйм = 0 м 53 см 3,4 мм
9.5 inch = 24.13 cm = 2m 4cm 1mm
*/
namespace HW_02_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length in inches: ");
            double len_inch = Convert.ToDouble(Console.ReadLine());
            const double conv_factor = 25.4;

            double len_mm = Convert.ToDouble(len_inch * conv_factor);
            Console.WriteLine($"{len_inch} inches is {len_mm}mm");

            int mm = Convert.ToInt32(len_mm % 10);
            int cm = Convert.ToInt32((len_mm / 10) % 10);
            int meters = Convert.ToInt32(len_mm / 100);
            
            Console.WriteLine($"{len_inch} inches is {meters}m {cm}cm {mm:F1}mm");
        }
    }
}
