// Составить регулярное выражение для проверки корректности пароля.
// Пароль должен состоять минимум из 14 символов и иметь в составе
// минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.
// Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.
// 12345671234567#aZ
using System.Text.RegularExpressions;

namespace HW_06_Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string? pwd = Console.ReadLine();

            Regex rgx = new Regex(@"^(?=.*\d)(?=.*[A-Z])(?=.*[!#;%:?*.]).{14,}$");

            while (string.IsNullOrWhiteSpace(pwd) && !rgx.IsMatch(pwd))
            {
                Console.Write("Choose new password: ");
                pwd = Console.ReadLine();
            }
            Console.WriteLine("Password is correct");
            //string[] test =
            //{
            //    "12345671234567#aZ", "+9(000)000-00-00", "1234567",
            //    "Zaqw123-_", "azsxdcfvgbhnjmk,l", "___===--988", pwd,
            //};

            //foreach (string str in test)
            //{
            //    if (rgx.IsMatch(str)) Console.WriteLine($"{str} is ok"); 
            //    else Console.WriteLine($"{str} is not ok");
            //}
        }
    }
}
