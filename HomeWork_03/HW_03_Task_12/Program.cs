// Дано целое число в диапазоне 0–999.
// Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть»,
// 814 — «восемьсот четырнадцать».
// Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
namespace HW_03_Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int threeDigit = Convert.ToInt32(Console.ReadLine());

            if (threeDigit >= 1000 || threeDigit < 0)
            {
                throw new Exception("Number out of bounce");
            }
            if (threeDigit == 0)
            {
                Console.WriteLine("ноль");
                return;
            }

            int firstDigit = threeDigit / 100;
            int secondDigit = (threeDigit / 10) % 10;
            int units = threeDigit % 10;

            string hundredsWord = HundredsInWord(firstDigit);
            string teensWord;
            string tensWord;
            string unitsWord;

            string res = "";
            if (hundredsWord != "")
            {
                res += hundredsWord;
            }

            // 10-19: 311; 419
            if (secondDigit == 1)
            {
                teensWord = TeensInWord(secondDigit*10 + units);
                res += " " + teensWord;   
            }
            else // 0-9: 201;
            {
                unitsWord = UnitsInWord(units);
                tensWord = TensInWord(secondDigit*10);
                if (tensWord != "")
                {
                    res += " " + tensWord;
                }
                res += " " + unitsWord;
            }
            Console.Write($"{res.Trim()}");
        }

        static string HundredsInWord(int hundreds)
        {
            switch (hundreds)
            {
                case 1: return "сто";
                case 2: return "двести";
                case 3: return "триста";
                case 4: return "четыреста";
                case 5: return "пятьсот";
                case 6: return "шестьсот";
                case 7: return "семьсот";
                case 8: return "восемьсот";
                case 9: return "девятьсот";
                default: return "";
            }
        }

        static string TeensInWord(int twoDigitNumber)
        {
            switch (twoDigitNumber)
            {
                case 10: return "десять";
                case 11: return "одиннадцать";
                case 12: return "двенадцать";
                case 13: return "тринадцать";
                case 14: return "четырнадцать";
                case 15: return "пятнадцать";
                case 16: return "шестнадцать";
                case 17: return "семнадцать";
                case 18: return "восемнадцать";
                case 19: return "девятнадцать";
                default: return "";
            }
        }
        static string UnitsInWord(int units)
        {
            switch (units)
            {
                case 1: return "один";
                case 2: return "два";
                case 3: return "три";
                case 4: return "четыре";
                case 5: return "пять";
                case 6: return "шесть";
                case 7: return "семь";
                case 8: return "восемь";
                case 9: return "девять";
                default: return "";
            }
        }
        static string TensInWord(int tens)
        {
            switch (tens)
            {
                case 20: return "двадцать";
                case 30: return "тридцать";
                case 40: return "сорок";
                case 50: return "пятьдесят";
                case 60: return "шестьдесят";
                case 70: return "семьдесят";
                case 80: return "восемьдесят";
                case 90: return "девяносто";
                default: return "";
            }
        }
    }
}
