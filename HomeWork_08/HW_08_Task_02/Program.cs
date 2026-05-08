// Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
//•    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
//•    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").
namespace HW_08_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Input is empty.");
                    continue;
                }
                try
                {
                    age = Convert.ToInt32(input);
                    ValidateAge(age);
                    Console.WriteLine("Age is valid.");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Not a number {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }
            else if (age > 150)
            {
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
            }
        }
    }
}
