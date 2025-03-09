namespace BankAccount.Task
{
    class Program
    {
        static void Main()
        {
            
            var account = new BankAccount("123456789", "John Doe", 1000.00m);
          

            account.Deposit(500.00m);  
            account.Withdrawl(200.00m); 
            account.Withdrawl(200.00m); 

           
            Console.WriteLine($"Final balance: {account.Balance:C}");

            account.DisplayTransactionHistory();

            var account2 = new BankAccount("987654321", "Alice", 900.00m);

            account2.Deposit(500.00m);
            account2.Withdrawl(200.00m);
            account2.Withdrawl(200.00m);


            Console.WriteLine($"Final balance: {account2.Balance:C}");

            account2.DisplayTransactionHistory();
        }
    }
}
