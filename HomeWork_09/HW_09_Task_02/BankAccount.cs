using System;
using System.Collections.Generic;
using System.Text;

namespace HW_09_Task_02
{
    internal class BankAccount
    {
        private static int _totalAccounts = 0;
        public int AccountNumber { get; }
        public decimal Balance {  get; private set; }
            
        public BankAccount() 
        {
            Random rnd = new Random();
            AccountNumber = rnd.Next(1000, 10000); 
            Balance = 0; 
            _totalAccounts++;
        }
       
        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Ammount must be positive");
            
            Balance += amount; 
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                throw new InvalidOperationException("Not enough funds in the account");
            }
            if (amount <= 0) throw new ArgumentException("Ammount must be positive");

            Balance -= amount;
        }

        public void ShowTotalAccounts()
        {
            Console.WriteLine($"Total amount of accounts: {BankAccount._totalAccounts}");
        }

        public override string ToString()
        {
            return $"Account: {AccountNumber}; balance: {Balance} rub.";
        }
    }
}
