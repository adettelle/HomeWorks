namespace HW_poligon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            int hundreds = threeDigitNumber / 100;
            Console.WriteLine($"hundreds are {hundreds}");

            int secondDigitNumber = (threeDigitNumber / 10) % 10;
            Console.WriteLine($"secondDigitNumber is {secondDigitNumber}");


            int units = threeDigitNumber % 10;
            Console.WriteLine($"units are {units}");

            if (secondDigitNumber == 1)
            {
                Console.WriteLine($"teens are {secondDigitNumber}");
            }
        }
    }
}
