using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string Owner { get; }
        public decimal Balance { get; private set; }

        private List<Transaction> _transactions = new List<Transaction>();

        public BankAccount(string accountNumber, string owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException($"{nameof(amount)} must be larger than 0");
            }

            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException($"{nameof(amount)} must be larger than 0");
            }

            if(Balance < amount)
            {
                throw new ArgumentException($"{nameof(amount)} must be less than {nameof(Balance)}");
            }

            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdrawal));
        }

        public List<Transaction> GetTransactions() { return _transactions; }
    }
}
