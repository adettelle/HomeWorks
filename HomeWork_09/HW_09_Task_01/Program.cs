// Создайте класс Book, который содержит:
//    Поля:
//        _title (название книги, private)
//        _author (автор, private)
//    Автосвойства:
//        Year (год издания, public геттер, public сеттер)
//        Pages (количество страниц, public геттер, public сеттер)
//    Конструктор:
//        Инициализирует все поля и свойства
//    Метод:
//        GetInfo() – возвращает строку с информацией о книге (например: "Война и мир, Л. Толстой, 1869, 1225 стр.")

namespace HW_09_Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("Война и мир", "Л. Толстой", 2000, 1255);
            book1.Year = 1869;
            try
            {
                book1.Pages = -1000;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error is: {ex.Message}");
            }
            book1.GetInfo();

            var book2 = new Book("Hamlet", "William Shakespeare", 1603, 289);
            try
            {
                book2.Year = -111;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error is: {ex.Message}");
            }
            book2.GetInfo();

            var book3 = new Book("The Three-Body Problem", "Liu Cixin", 2015, 448);
            book3.GetInfo();

        }
    }
}
