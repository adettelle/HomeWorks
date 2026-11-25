// Создайте обобщенный класс Book<T, U>, который представляет книгу со следующими свойствами://    Code - уникальный код книги (тип T)
//    Title - название книги (тип string)
//    PublicationYear - год публикации (тип U)
//    Author - автор книги (тип string)

// Реализуйте в классе:
//    Конструктор, принимающий все параметры
//    Переопределенный метод ToString(), возвращающий информацию в формате:
//    Код: {Code} ({тип T}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({тип U})

// Создайте обобщенный метод FindBook, который:
//    Принимает массив книг Book<T, U>[] и код книги code типа T
//    Возвращает книгу с указанным кодом или null, если книга не найдена

// В методе Main продемонстрируйте работу:
//    Создайте два массива книг:
//        Первый массив: Code - string (шифр книги), PublicationYear - int
//        Второй массив: Code - int (инвентарный номер), PublicationYear - string (исторические периоды)
//    Найдите и выведите информацию о книгах:
//        Книгу с кодом "F-1234" из первого массива
//        Книгу с кодом 42 из второго массива
namespace HW_12_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("Title1", "code111", 1111, "Author1"),
                new Book<string, int>("Title2", "F-1234", 2222, "Author2"),
                new Book<string, int>("Title3", "code333", 3333, "Author3")
            };

            Book<int, string>[] books2 = new Book<int, string>[]
                {
                    new Book<int, string>("T1", 1234, "year111", "A1"),
                    new Book<int, string>("T1", 2345, "year222", "A2"),
                    new Book<int, string>("T1", 42, "year333", "A3")
                };
            Book<string, int> b1 = FindBook<string, int>(books1, "F-1234");
            Book<int, string> b2 = FindBook<int, string>(books2, 42);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }

        static public Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (Book<T, U> book in books)
            {
                if (book.Code.Equals(code)) return book;
            }
            return null;
        }
    }

    class Book<T, U>
    {
        public string Title { get; set; } // название книги(тип string)
        public T Code { get; set; }
        public U PublicationYear { get; set; } //год публикации (тип U)
        public string Author { get; set; } // автор книги (тип string)
        public Book(string title, T code, U publicationYear, string author)
        {
            Title = title; Code = code; PublicationYear = publicationYear; Author = author;
        }

        public override string ToString()
        {
            return $"Code: {Code}, Title: {Title}, Author: {Author}, Year: {PublicationYear} ({typeof(U).Name})";
        }
    }
}
