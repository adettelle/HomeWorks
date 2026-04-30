// Нужно создать отчёт, который будет содержать информацию о продажах за определённый период.
// Отчёт должен быть отформатирован следующим образом:
//    Название отчёта: "Отчёт о продажах за [месяц] [год]".
//    Информация о продажах:
//        Общая сумма продаж.
//        Количество проданных товаров.
//        Средняя стоимость одного товара.

// Общая сумма продаж должна быть отформатирована как денежная величина
// (с разделителями тысяч и двумя знаками после запятой).
// Средняя стоимость товара должна быть отформатирована с двумя знаками после запятой.

// Пример данных:
//    Месяц: "Март"
//    Год: 2025
//    Общая сумма продаж: 1234567.89
//    Количество проданных товаров: 1234

// Пример отчёта:

// --------------------------------
// Отчёт о продажах за Март 2025
// --------------------------------
// Общая сумма продаж: 1 234 567,89 р.
// Количество проданных товаров: 1 234 шт.
// Средняя стоимость товара: 1 000,46 р.
// --------------------------------
using System.Globalization;

namespace HW_06_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a month: ");
            string? month = Console.ReadLine(); 
            while (string.IsNullOrWhiteSpace(month))
            {
                Console.Write("Empty input. Enter a month: ");
                month = Console.ReadLine();
            }
            string monthCapitalized = char.ToUpper(month[0]) + month.Substring(1);

            Console.Write("Enter a year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Invalid year. Try again: ");
            }

            Console.Write("Enter total sales: ");
            double sales;
            while (!double.TryParse(Console.ReadLine(), 
                                    NumberStyles.Any, 
                                    CultureInfo.InvariantCulture,
                                    out sales))
            {
                Console.Write("Invalid number. Try again: ");
            }

            Console.Write("Enter a number of items sold: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid quantuty. Try again: ");
            }
            double avgCost = sales / number;
            string separator = new string('-', 40);
            Console.WriteLine(separator);
            Console.WriteLine($"Sales report for {monthCapitalized} {year}");
            Console.WriteLine(separator);

            Console.WriteLine($"Total sales: {sales:N2} $");
            Console.WriteLine($"Number of items sold: {number} pieces");
            // Console.WriteLine($"Average cost of goods: {String.Format("{0:N2}", sales / number)} $");
            Console.WriteLine($"Average cost of goods: {avgCost:N2} $");
            Console.WriteLine(separator);

        }
    }
}
