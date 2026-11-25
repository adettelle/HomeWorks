// Создайте интерфейс IFlyable с:
//     методом Fly() (без реализации),
//     свойством MaxAltitude (int, только чтение).

// Реализуйте интерфейс в классе Bird (птица), добавив:
//      реализацию Fly() (выводит "Лечу на высоте {MaxAltitude} метров"),
//      конструктор, принимающий maxAltitude.

// Реализуйте интерфейс в классе Airplane (самолет), добавив:
//     свойство CountPassengers - количество пассажиров (int),
//     реализацию Fly() (выводит
//     "Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров"),
//     конструктор, принимающий maxAltitude и CountPassengers.

// В методе Main продемонстрируйте:
//     создание массива, содержащего объекты обоих типов,
//     использование полиморфизма (вызовите для каждого элемента в массиве метод Fly()).
namespace HW_11_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyers = new IFlyable[]
            {
                new Bird(700),
                new Airplane(1000, 580)
            };

            foreach (var flyer in flyers)
            {
                flyer.Fly();
            }
            Console.WriteLine();

            Bird bird = new Bird(50);
            bird.Fly();

            Airplane a1 = new Airplane(10000, 1000);
            a1.Fly();
        }
    }

    public interface IFlyable
    {
        void Fly();
        int MaxAltitude { get; }
    }

    public class Bird :IFlyable
    {
        public int MaxAltitude { get; }

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }

        public void Fly()
        {
            Console.WriteLine($"I'm flying at an altitude of {MaxAltitude} meters.");
        }
    }
    public class Airplane : IFlyable
    {
        public int CountPassengers { get; }
        public int MaxAltitude { get; }

        public Airplane(int maxAltitude, int countPassengers)
        {
            CountPassengers = countPassengers;
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"I'm flying at an altitude of {MaxAltitude} meters. " +
                $"I'm carrying {CountPassengers} passengers.");
        }
    }
}
