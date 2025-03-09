using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Task
{
    
    public partial class BankAccount
    {
       
        

        private void LogTransaction(decimal amount)
        {
            if (_transactionCount < _transactions.Length)
            {
                _transactions[_transactionCount++] = new TransactionHistory(amount);
            }

        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            Balance += amount;

            LogTransaction(amount);

            string message = $"Deposited {amount}. New balance: {Balance}.";

            Console.WriteLine(message);
           
        }

        public void Withdrawl(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            Balance -= amount;
            
            LogTransaction(-amount);
            string message = $"Withdrew {amount}. New balance: {Balance}.";
            Console.WriteLine(message);
             



        }

        public void DisplayTransactionHistory()
        {
            if(_transactionCount == 0)
            {
                Console.WriteLine("Dont have transaction in history.");
                return;
            }

            for (int i = 0; i < _transactionCount; i++)
            {

                if (_transactions[i].Amount < 0)
                {
                    Console.WriteLine($"Withdrawl: {_transactions[i]}");
                }
                else
                {
                    Console.WriteLine($"Deposit: {_transactions[i]}");
                }
            }

        }
    }



   

}
