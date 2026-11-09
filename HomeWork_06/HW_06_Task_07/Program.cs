using System.Text;

namespace Example4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку из слов, разделенных пробелами:");
            string input = Console.ReadLine();
            string[] words = input.Split(' '); // Разделяем строку на слова

            // Используем StringBuilder для эффективной работы со строками
            StringBuilder result = new StringBuilder();

            // Обрабатываем каждое слово
            foreach (string word in words)
                if (!string.IsNullOrEmpty(word))
                    // Делаем первую букву заглавной и добавляем остальную часть слова
                    result.Append(char.ToUpper(word[0]) + word.Substring(1) + " ");

            // Убираем последний пробел
            if (result.Length > 0)
                result.Length--; // Удаляем последний пробел

            Console.WriteLine("Результат:");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}