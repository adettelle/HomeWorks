using System.Xml.Linq;

namespace HW_09_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");
            Person person1 = new Person { Name = "Ane" };
            person1.Print();

            person1 = new Employee { Name = "Sam" };
            person1.Print();
        }
    }

    class Person
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
