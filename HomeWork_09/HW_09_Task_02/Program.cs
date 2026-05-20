// Создайте класс BankAccount, который моделирует банковский счет:
//    Статическое поле:
//        _totalAccounts (общее количество созданных счетов, private)
//    Автосвойства:
//        AccountNumber (номер счета, readonly)
//        Balance (public геттер, private сеттер)
//    Конструктор:
//        Увеличивает _totalAccounts и генерирует AccountNumber (например, случайный 4-значный номер).
//    Методы:
//        Deposit(decimal amount) – пополняет баланс.
//        Withdraw(decimal amount) – снимает деньги (если хватает средств, иначе выбрасывает исключение).
//        ShowTotalAccounts() - выводит общее количество созданных счетов.

namespace HW_09_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAcc1 = new BankAccount();
            bankAcc1.Deposit(100);
            bankAcc1.Withdraw(50);
            bankAcc1.ShowTotalAccounts();

            var bankAcc2 = new BankAccount();
            bankAcc2.Deposit(100);
            try
            {
                bankAcc2.Withdraw(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erros is: {ex.Message}");
            }
            bankAcc2.ShowTotalAccounts();

            Console.WriteLine(bankAcc1);
            Console.WriteLine(bankAcc2);
        }
    }    
}
