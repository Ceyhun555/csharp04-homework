using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Task
{
    public partial class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }

        private readonly TransactionHistory[] _transactions;

        private int _transactionCount = 0;

        public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
            _transactions = new TransactionHistory[100];

        }


        partial void NotifyTransaction(string message);

        partial void TransactionHistory();
    }
}
