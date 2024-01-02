using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Transaction
    {
        public decimal Ammount { get; }
        public DateTime Date { get; }
        public TransactionType Type { get; }

        public Transaction(decimal ammount, TransactionType type)
        {
            Ammount = ammount;
            Date = DateTime.Now;
            Type = type;
        }
    }
}
