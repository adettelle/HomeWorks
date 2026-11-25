namespace HW_12_Task_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// boxing: int превращаем в Object
            //Product<int, decimal> p1 = new Product<int, decimal>("milk", 100, 1);
            //// делаем явное приведение: (int)p1.Id
            //// unboxing: Object превращаем в int
            //int next = (int)p1.Id + 1;
            //Console.WriteLine(p1);
            //Product<string, string> p2 = new Product<string, string>("bread", "0.001 BTC", "bb12");
            //Console.WriteLine(p2);

            Product<int, decimal>[] products = new Product<int, decimal>[]
            {
                new Product<int, decimal>("milk2", 2200, 22),
                new Product<int, decimal>("milk3", 3300, 33),
                new Product<int, decimal>("milk4", 4400, 44),
            };
            Product<int, decimal> prod = FindProduct<int, decimal> (products, 5);

            //if (prod == null) Console.WriteLine("Not found");
            //else  Console.WriteLine(prod);
            
            // синтаксический сахар prod?
            // чтоьы не было null reference exeption,
            // то есть попытка вызвать ToString() на объект null
            Console.WriteLine(prod?.ToString() ?? "Not found");
        }

        // все методы в классе Main должны быть static
        // проверяем, есть ли в массиве товар с таким id,
        // то есть переменную типа Product<Task, U>
        static Product<T, U> FindProduct<T, U>(Product<T, U>[] products, T id)
        {
            foreach (Product<T, U> product in products)
            {
                if (product.Id.Equals(id))
                {
                    return product;
                }
            }
            return null;
        }
    }


    class Product <T, U>
        // если мы хотим поставиь ограничение на тип U (например)
        // where U:struct // struct - это значимый тип, то есть теперь U может быть разными типами,
        // но не ссылочными (а string как раз явлется сылочным типом)
    {
        public string Name { get; set; }
        // decimal обычно используют для денежных единиц.
        public U Price { get; set; }
        // мы хотим,  чтоьбы Id мог быть int или string в разных магазинах
        // Object - это самый главный базовый тип для абсолютно всех типов в платформе .NET
        // в том числе для int и string
        public T Id { get; set; }

        public Product(string name, U price, T id)
        {
            Name = name; Price = price; Id = id;
        }

        // у Obect есть метод ToString. Переопределим его
        public override string ToString()
        {
            return $"ID: {Id} ({typeof(T).Name}), Name: {Name}, " +
                $"Price: {Price} ({typeof(U).Name})";
        }
    }
}
