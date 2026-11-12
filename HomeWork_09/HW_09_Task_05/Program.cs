namespace HW_09_Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Developer("Alice", "C#");
            employee.Introduce();
            employee.Work();
        }
    }

    public interface IEmployee
    {
        void Work();
    }

    public abstract class Employee : IEmployee
    {
        public string Name { get; set; }
        // protected
        protected Employee(string name) 
        {
            Name = name;
        }

        public abstract void Work();

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }

    public class Developer : Employee
    {
        public string Language { get; set; }
        public Developer(string name, string language)
            : base(name)
        {
            Language = language;
        }
        public override void Work()
        {
            Console.WriteLine($"Writing code in {Language}");
        }
    }
}
