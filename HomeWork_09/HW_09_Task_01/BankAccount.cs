using System;
using System.Collections.Generic;
using System.Text;

namespace HW_09_Task_02
{
    internal class BankAccount
    {
        private static int _totalAccounts = 0;
        public readonly string AccountNumber;
        public decimal Balance {  get; private set; }

        public int TotalAccounts;
            
        public BankAccount(int totalAccounts, int accountNumber, int balance)
        {
            AccountNumber = Guid.NewGuid().ToString();
            Balance = balance;
            _totalAccounts++;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount; // 
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                throw new ArgumentOutOfRangeException("Not enough funds in the account");
            }
            Balance -= amount;
        }

        public void ShowTotalAccounts()
        {
            Console.WriteLine($"Total amount of accounts: {BankAccount._totalAccounts}");
        }
    }
}
