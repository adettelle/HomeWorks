namespace HW_08_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int a = Convert.ToInt32(Console.ReadLine());
                //int b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(a / b);
                Console.WriteLine(Divide(Console.ReadLine(), Console.ReadLine()));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Number is too big: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"It is not a number: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Division by zero: {ex.Message}");
            }
        }

        static int Divide( string a, string b )
        {
            int aa = Convert.ToInt32(a);
            int bb = Convert.ToInt32(b);
            return aa / bb; 
        }
    }
}
