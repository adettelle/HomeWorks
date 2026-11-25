//«Код да Винчи» (циклы, шифрование, строки)
//Шифр Атбаш - это простой шифр подстановки для алфавитного письма,
//в котором каждая n-я буква алфавита заменяется буквой m - n + 1,
//где m - общее число букв в алфавите. Другими словами, первая буква заменяется на последнюю,
//вторая -на предпоследнюю и так далее (например, A → Z, B → Y, C → X).

//Знание шифра Атбаш приходит на помощь героям книги Дэна Брауна «Код да Винчи» — Роберту Лэнгдону,
//Софи Невё и Ли Тибингу, когда они берутся разгадать смысл стихотворной строки —
//«…атбаш правду высветит, как луч». По сюжету выясняется, что с помощью шифра Атбаш
//было зашифровано слово «Бафомет», помогающее отгадать слово «София».

//Напишите программу, которая:
//    Шифрует введенный пользователем текст (например, "HELLO 123").
//    Дешифрует её обратно.

//Пример шифрования:
//HELLO 123 → SVOOL 123
using System.Text;

namespace HW_13_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            Console.WriteLine("Hello, write a line to code!");
            // 
            line = Console.ReadLine() ?? "";

            string codedLine = Code(line);
            Console.WriteLine($"Here is the coded line: {codedLine}");
            string decodedLine = Code(codedLine);
            Console.WriteLine($"Result - decoded line: {decodedLine}");
        }

        // 'A' = 65, 'Z' = 90, 'a' = 97, 'z' = 122
        static string Code(string line)
        {
            StringBuilder sb = new StringBuilder();

            //int m1 = 218; // 122 = m - 97 + 1
            //int m2 = 154; // 90 = m - 65 + 1

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                //int asciiCode = (int)ch;
                int newAsciiCode; 

                if (ch >= 'a' && ch <= 'z') // (asciiCode >= 97 && asciiCode <= 122)
                {
                    //newAsciiCode = m1 - asciiCode + 1;
                    newAsciiCode = 'z' - ch + 'a';
                    sb.Append((char)newAsciiCode);
                    //sb.Append((char)('z' - ch + 'a'));
                }
                else if (ch >= 'A' && ch <= 'Z') // (asciiCode >= 65 && asciiCode <= 90)
                {
                    //newAsciiCode = m2 - asciiCode + 1;
                    newAsciiCode = 'Z' - ch + 'A';
                    sb.Append((char)newAsciiCode);
                }
                else sb.Append(line[i]);
            }
            return sb.ToString();
        }
    }
}
