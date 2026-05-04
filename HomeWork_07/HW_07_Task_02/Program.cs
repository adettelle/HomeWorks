// Создайте метод CalcCube для вычисления объема и площади поверхности куба по длине его ребра.
// Метод должен иметь 3 параметра - длина ребра,
// out-параметр для объема и out-параметр для площади поверхности.
// Пример вызова:
// double edgeLength = 5;
// CalcCube(edgeLength, out volume, out surfaceArea);
// Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
// Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); // Площадь поверхности куба: 150
namespace HW_07_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a lenght of a cube: ");
            int edge = Convert.ToInt32(Console.ReadLine());

            int area;
            int volume;

            CalcCube(edge, out area, out volume);
            Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
            Console.WriteLine($"Площадь поверхности куба: {area}"); // Площадь поверхности куба: 150
        }

        static void CalcCube(int edge, out int area, out int volume)
        {
            area = edge * edge * 3;
            volume = edge * edge * edge;

        }
    }
}
