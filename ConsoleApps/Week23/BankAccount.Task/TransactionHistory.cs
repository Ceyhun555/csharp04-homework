using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Task
{
    public class TransactionHistory
    {
        public decimal Amount { get; }
        public DateTime TransactionDate { get; }

        public TransactionHistory(decimal amount)
        {
            Amount = amount;
            TransactionDate =  DateTime.Now;
        }

        public override string ToString()
        {
            return $"Amount: {this.Amount}, Transaction date: {this.TransactionDate}";
        }
    }
}