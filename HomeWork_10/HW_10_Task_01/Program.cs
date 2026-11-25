// Создайте базовый класс Building (описывает здание) со следующими характеристиками:
//        Поля:
//            _address (строка) - адрес здания
//            _area (double) - площадь в квадратных метрах
//            _yearBuilt (int) - год постройки
//        Конструктор, инициализирующий эти поля
//        Виртуальные методы:
//            CalculateTax() - рассчитывает налог (базовая формула: площадь × 1000)
//            DisplayInfo() - выводит информацию о здании
//        Свойство:
//            BuildingAge (только чтение) - возраст здания в годах

// Создайте производный класс MultiBuilding (многоэтажное здание), который:
//        Добавляет новые поля:
//            _floors (int) - количество этажей
//            _hasElevator (bool) - наличие лифта
//        Модифицирует поведение:
//            Переопределяет CalculateTax() с учетом:
//                Повышающего коэффициента за этажи (1 + (_floors - 1) * 0.05)
//                Доплаты 5000 за наличие лифта
//            Переопределяет DisplayInfo() для вывода дополнительной информации
//        Добавляет новые возможности:
//            Свойство AreaPerFloor (только чтение) - средняя площадь на этаж
//        Запрещает наследование

// В методе Main продемонстрируйте:
//        Создание объектов обоих типов
//        Upcasting (приведение производного класса к базовому)
//        Downcasting (обратное приведение с проверкой типа)
//        Вызов переопределенных методов
//        Использование уникальных методов производного класса
using System.Globalization;

namespace HW_10_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Используем российскую культуру, где разделитель разрядов — пробел
            var culture = CultureInfo.GetCultureInfo("ru-RU");

            Building b1 = new Building("Moscow, Lenina str, 45", 256, 1870);
            MultiBuilding mb1 = new MultiBuilding("Omsk, Green str, 12", 546, 2020, 3, true);

            Console.WriteLine("=== BUILDING ===");
            b1.DisplayInfo();
            Console.WriteLine($"Age: {b1.BuildingAge}");
            // Вывод с дробной частью: "256 000,00"
            Console.WriteLine($"Tax: {b1.CalculateTax().ToString("N0", culture):N2}");

            Console.WriteLine("\n=== MULTIBUILDING ===");
            mb1.DisplayInfo();
            Console.WriteLine($"Age: {mb1.BuildingAge}");
            Console.WriteLine($"Tax: {mb1.CalculateTax().ToString("N0", culture):N2}");
            Console.WriteLine($"Area per floor: {mb1.AreaPerFloor}");

            Console.WriteLine("\n=== UPCASTING ===");

            // 7. Как можно использовать Upcasting и Downcasting?
            // Upcasting — приведение дочернего класса к родительскому
            // переменная b2 имеет тип Building, но фактически продолжает ссылаться на объект MultiBuilding
            Building b2 = mb1;
            // Несмотря на тип Building, вызывается метод MultiBuilding
            b2.DisplayInfo();
            Console.WriteLine($"Tax: {b2.CalculateTax().ToString("N2", culture):N0}");
            // выполнится именно переопределённый метод класса MultiBuilding!
            // Это называется полиморфизмом.

            Console.WriteLine("\n=== DOWNCASTING ===");

            // Downcasting — обратное приведение
            // одновременно проверяет тип и выполняет приведение.
            if (b2 is MultiBuilding mb)
            {
                Console.WriteLine($"Area per floor: {mb.AreaPerFloor}");
                Console.WriteLine($"Tax: {mb.CalculateTax().ToString("N2", culture):N0}");
            }

            // или
            MultiBuilding mbV2 = b2 as MultiBuilding;

            if (mbV2 != null)
            {
                Console.WriteLine($"Tax: {mbV2.CalculateTax()}");
            }
        }
    }

    public class Building
    {
        private string _address;
        private double _area;
        private int _yearBuilt;

        // Конструктор, инициализирующий эти поля
        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }

        // Свойство для доступа к площади
        // чтобы можно было обратиться к _area из дочернего класса надо создать
        // свойство Area в родительском классе
        public double Area => _area;

        // Виртуальные методы:
        // Вывод информацию о здании
        public virtual void DisplayInfo() 
        {
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine($"Built in: {_yearBuilt}");
            Console.WriteLine($"Area: {_area}");
        }

        // Базовый расчёт налога (базовая формула: площадь × 1000)
        public virtual double CalculateTax()
        {
            return _area * 1000;
        }

        // 1. Как создать свойство (только чтение) возраст здания в годах BuildingAge?
        // readonly: это модификатор полей, а не свойств.

        //public int BuildingAge
        //{
        //    get
        //    {
        //        return DateTime.Now.Year - _yearBuilt;
        //    }
        //}

        // или короче
         public int BuildingAge => DateTime.Now.Year - _yearBuilt;

    }

    // sealed запрещает дальнейшее наследование
    // то есть от класса MultiBuilding больше нельзя создавать дочерние классы.
    // Для этого используется ключевое слово sealed.
    // То есть класс public class Skyscraper : MultiBuilding {} создать уже нельзя
    public sealed class MultiBuilding : Building
    {
        // новые поля:
        private int _floors; // количество этажей
        private bool _hasElevator; // наличие лифта

        // Конструктор
        // 2. При создании дочернего класса как добавить к родительскому классу
        // доп поля (int floors, bool hasElevator)?
        public MultiBuilding(string address, double area, int yearBuilt, 
                             int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        // 3. Как у дочернего класса использовать родительскую площадь? 
        // Модифицируем поведение:
        // есть овышающий коэффициент за этажи (1 + (_floors - 1) * 0.05) и
        // доплаты 5000 за наличие лифта
        public override double CalculateTax()
        {
            double tax = base.CalculateTax();
            tax *= (1 + (_floors - 1) * 0.05);
            if (_hasElevator) tax += 5000;
            return tax;
        }

        // 4. Как использовать родительскую информацию и к ней добавить
        // новую об этажах в DisplayInfo()?
        // Переопределение вывода информации
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine($"Floors: {_floors}");
            // 5. Можно ли использовать тернарный оператор прямо в Console.WriteLine()?
            Console.WriteLine($"Has elevator: {(_hasElevator ? "YES" : "NO")}");
        }

        // 6. Как добавить новое свойство (только чтение) - средняя площадь на этаж
        public double AreaPerFloor => Area / _floors;
        // или
        //public double AreaPerFloor
        //{
        //    get
        //    {
        //        return Area / _floors;
        //    }
        //}
    }
}
