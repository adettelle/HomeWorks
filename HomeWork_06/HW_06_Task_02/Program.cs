// Ввести с клавиатуры предложение.
// Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
// Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
// (пример палиндрома – «А роза упала на лапу Азора»).
namespace HW_06_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string? str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Empty input");
                return;
            }

            bool isPalindrome = true;
            // str = str.Replace(" ", "").ToLower();
            Console.WriteLine(str);
            /* version 1
            string reversed = new string(str.Reverse().ToArray());
            Console.WriteLine(reversed);

            Console.WriteLine($"Is the string a palindrome? {reversed == str}");
            */
            // version 2
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                while (i < j && str[i] == ' ') i++;
                while (i < j && str[j] == ' ') j--;

                char left = char.ToLower(str[i]);
                char right = char.ToLower(str[j]);

                if (left != right)
                {
                    isPalindrome = false;
                    break;
                }
                i++;
                j--;
            }
            Console.WriteLine($"Is the string a palindrome? {isPalindrome}");
        }
    }
}
