// Создайте абстрактный класс Animal с:
//     абстрактным свойством Name (string),
//     абстрактным методом Say(), который возвращает строку-звук, который издает животное,
//     неабстрактным методом ShowInfo(), который возвращает строку, содержащую последовательно
//     название, а затем звук (вызывая метод Say()).

// Реализуйте два класса-наследника:
//     Dog (собака), который переопределяет Say() (выводит "Гав!") и задает название животного,
//     Cat (кошка), который переопределяет Say() (выводит "Мяу!") и задает название животного.

// В методе Main продемонстрируйте:
//     создание массива, содержащего объекты обоих типов,
//     использование полиморфизма (вызовите для каждого элемента в массиве метод ShowInfo()).
namespace HW_11_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Cat(),
                new Dog()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ShowInfo());
            }
        }
    }

    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Say();
        public string ShowInfo() // void
        {
            // Console.WriteLine($"{Name} says: {Say()}");
            return $"{Name} says: {Say()}";
        }
    }

    public class Dog : Animal
    {
        
        public override string Name => "Dog";
        public override string Say()
        {
            return "\"Wow!\"";
        }
    }
    public class Cat : Animal
    {

        public override string Name => "Cat";
        public override string Say()
        {
            return "\"Meow!\"";
        }
    }
}

