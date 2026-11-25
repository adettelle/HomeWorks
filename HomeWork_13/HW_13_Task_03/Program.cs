//Игра «Угадай число» (циклы, условия, Random)
//Напишите консольную игру, где компьютер загадывает число от 1 до 100, а игрок угадывает его.
//    Программа должна подсказывать «Больше» или «Меньше».
//    При угадывании вывести количество попыток.
//    Используйте цикл while и обработку ввода (если пользователь ввёл не число).
namespace HW_13_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int pickedNum = rnd.Next(1, 101);
            //Console.WriteLine(pickedNum);
            Console.WriteLine("I've picked an integer. You have to guess it.");

            int number = 0;
            int attepmts = 0;

            while (number != pickedNum)
            {
                Console.WriteLine("Enter a number between 1 and 100:");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

                if (number < 0 || number > 100)
                {
                    Console.WriteLine("Number must be between 1 and 100!");
                    continue;
                }

                attepmts++;
                if (number > pickedNum)
                    Console.WriteLine("Number should be less.");
                else if (number < pickedNum)
                    Console.WriteLine("Number should be more.");
            }

            Console.WriteLine($"You are right! The picked number is: {pickedNum} " +
                $"and number of attemps is: {attepmts}!");
        }
    }
}

