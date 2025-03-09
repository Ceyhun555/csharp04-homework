using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Task
{
    public partial class BankAccount
    {
        partial void NotifyTransaction(string message)
        {

            Console.WriteLine($"[Transaction Log]: {message}");
        }

        private void LogTransaction(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }

        partial void TransactionHistory()
        {
            
        }
    }
}
