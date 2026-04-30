// Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
// Знаки препинания не используются.
// Найти самое длинное слово в строке.
// What a wonderfull day
namespace HW_06_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string? sentence = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sentence))
            {
                Console.WriteLine("Empty input");
                return;
            }
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words[0];
            foreach (string word in words) 
            {
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            Console.WriteLine($"word is {longestWord}, length is {longestWord.Length}");
        }
    }
}
