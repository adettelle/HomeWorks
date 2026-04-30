// Запросите у пользователя имя, возраст и город.
// Сформируйте строку в формате:
// "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.

using System.Diagnostics.Metrics;
using System.Text;

namespace HW_06_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            // sb.Append("Name: ");

            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Empty input. Try again: ");
                name = Console.ReadLine();
            }
            //sb.Append(name);
            //sb.Append(", Age: ");

            Console.Write("Enter your age: ");
            string? age = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(age))
            {
                Console.Write("Empty input. Try again: ");
                age = Console.ReadLine();
            }
            //sb.Append(age);
            //sb.Append(", City: ");

            Console.Write("Enter your city: ");
            string? city = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Empty input. Try again: ");
                city = Console.ReadLine();
            }
            //sb.Append(city);

            sb.Append("Name: ").Append(name)
                .Append(", Age: ").Append(age)
                .Append(", City: ").Append(city);

            Console.WriteLine(sb.ToString());

        }
    }
}
