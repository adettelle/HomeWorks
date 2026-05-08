// Смоделируйте работу простого калькулятора.
// Программа должна запрашивать 2 целых числа, а затем – код операции
// (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
// После этого на консоль выводится ответ.
// Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).
using System.ComponentModel.DataAnnotations;

namespace HW_08_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers; 
            int code;

            ParseData(out numbers, out code);
            // Console.WriteLine($"{numbers[0]}, {numbers[1]}, {code}");
            try
            {
                int result = Calc(numbers[0], numbers[1], code);
                Console.WriteLine($"result = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message );
            }
        }

        static void ParseData(out int[] numbers, out int code)
        {
            numbers = new int[2];
            code = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter two integer numbers: ");
                    string? input = Console.ReadLine();
                    if ( input == null )
                    {
                        Console.WriteLine("Input is empty.");
                        continue;
                    }

                    string[] data = input.Split(' ');
                    if (data.Length != 2)
                    {
                        Console.WriteLine("Enter exactly two numbers.");
                        continue; 
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        numbers[i] = Convert.ToInt32(data[i]);
                    }
                    break; // выход из цикла после успешного ввода
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Not an integer: {ex.Message}");
                }
            }

            while (true)
            { 

                try
                {
                    Console.Write("Enter operation code (1-4): ");
                    code = Convert.ToInt32(Console.ReadLine());
                    if (code < 1 || code > 4)
                    {
                        Console.WriteLine("Code must be from 1 to 4.");
                        continue;
                    }
                    break; 
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Not an integer: {ex.Message}");
                }
            }
        }

        static int Calc(int a, int b, int code)
        {
            switch (code)
            {
                case 1:
                    {
                        return a + b;
                    }
                case 2:
                    {
                        return a - b;
                    }
                case 3:
                    {
                        return a * b;
                    }
                case 4:
                    {
                        if (b == 0)
                        {
                            throw new DivideByZeroException("Divizion by zero");
                        }
                        return a / b;
                    }
                default:
                    throw new Exception("Invalid operation code");
            }
        }
    }
}
