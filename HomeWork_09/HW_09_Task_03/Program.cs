namespace HW_09_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем материалы
            var brick = new ConstructionMaterial("Brick", 1800, false);
            var wood = new ConstructionMaterial("Oak", 700, true);

            Console.WriteLine(brick);
            Console.WriteLine(wood);

            // Используем методы
            Console.WriteLine($"Weight of 2 m^3 of brick is: {brick.CalculateWeight(2)} kg");
            Console.WriteLine($"Weight of 0.5 m^3 of oak is: {wood.CalculateWeight(0.5)} kg");

            // Статические данные
            ConstructionMaterial.DisplayTotalMaterials();
            Console.WriteLine($"Unit of density measurement: {ConstructionMaterial.UnitOfMeasure}");
        }
    }
}

public class ConstructionMaterial
{
    // Поля
    private double _density; // плотность материала (кг/м³)
    // Константа
    public const string UnitOfMeasure = "кг/м^3"; // единица измерения плотности
    // Поле только для чтения (устанавливается в конструкторе)
    public readonly string MaterialID;  // уникальный ID материала
    // Статическое поле (общее для всех материалов)
    public static int TotalMaterialsCreated = 0; // счетчик созданных материалов

    // Автосвойства
    public string Name { get; set; }
    public bool IsEcoFriendly { get; private set; } // (можно изменить только в классе)

    // Полное свойство с проверкой
    public double Density
    {
        get => _density;
        set
        {
            if (value <= 0) throw new 
                    ArgumentException("Плотность не может быть отрицательной или нулевой!");
            _density = value;          
        }
    }

    // Конструкторы
    public ConstructionMaterial(string namr, double density, bool isEcoFriendly)
    {
        Name = Name;
        Density = density;
        IsEcoFriendly = isEcoFriendly;
        MaterialID = Guid.NewGuid().ToString(); // генерируем уникальный ID
        TotalMaterialsCreated++;
    }

    // Статический конструктор (инициализирует статические данные)
    static ConstructionMaterial()
    {
        Console.WriteLine("Инициализация системы учета стройматериалов...");
    }

    // Метод экземпляра
    public double CalculateWeight(double value)
    {
        return value * Density;  // масса = объем * плотность
    }

    // Статический метод
    public static void DisplayTotalMaterials()
    {
        Console.WriteLine($"Всего материалов создано: {TotalMaterialsCreated}");
    }

    // Переопределение ToString()
    public override string ToString()
    {
        return $"{Name} (ID: {MaterialID}), Density: {Density} {UnitOfMeasure}" +
            $"Eco friendly: {(IsEcoFriendly ? "Yes" : "No")}";
    }
}