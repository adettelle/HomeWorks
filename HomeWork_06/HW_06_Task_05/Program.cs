// Составить регулярное выражение для проверки корректности номера телефона.
// Корректный номер имеет формат +7(123)456-78-90.

using System.Text.RegularExpressions;

namespace HW_06_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test =
            {
                "+7(123)456-78-90", "+9(000)000-00-00", "-7(123)456-78-90",
                "+K(123)456-78-90", "+7(123)456-781-901", "+77(123)456-78-90"
            };

            Regex rgx = new Regex(@"\+[0-9]\([0-9]{3}\)[0-9]{3}\-[0-9]{2}\-[0-9]{2}");

            foreach (string str in test)
            {
                if (rgx.IsMatch(str)) Console.WriteLine($"{str} is ok");
                else Console.WriteLine($"{str} is not ok");
            }
        }
    }
}
