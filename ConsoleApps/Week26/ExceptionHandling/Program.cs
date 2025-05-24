namespace ExceptionHandling
{
    internal class Program
    {
        static void Main()
        {
            //Task 1:

            Console.Write("Enter numerator: ");
            double numerator = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter denominator: ");
            double denominator = Convert.ToDouble(Console.ReadLine());

            // Logical Implementation
            if (denominator == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                double result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }

            // Try-Catch Implementation
            try
            {
                double resultTryCatch = numerator / denominator;
                Console.WriteLine($"Result (Try-Catch): {resultTryCatch}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            Console.WriteLine();






            //Task 2:
            LogicalImplementation();
            TryCatchImplementation();

            Console.WriteLine();





            //Task 3:
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Enter an index (0 to 4):");
            int index = int.Parse(Console.ReadLine());

            // Logical Implementation
            if (index >= 0 && index < numbers.Length)
            {
                Console.WriteLine("Value at index {0}: {1}", index, numbers[index]);
            }
            else
            {
                Console.WriteLine("Error: Index out of range. Please enter a valid index.");
            }

            // Try-Catch Implementation
            try
            {
                Console.WriteLine("Value at index {0}: {1}", index, numbers[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index out of range. Please enter a valid index.");
            }
            Console.WriteLine();




            //Task 4:

            // Logical Implementation
            string logicalString = null;
            if (logicalString == null)
            {
                Console.WriteLine("Error: The object is null. Cannot access properties of a null object.");
            }
            else
            {
                Console.WriteLine(logicalString.Length);
            }

            // Try-Catch Implementation
            string tryCatchString = null;
            try
            {
                Console.WriteLine(tryCatchString.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: The object is null. Cannot access properties of a null object.");
            }
            Console.WriteLine();





            //Task 5:

            try
            {
                BankAccount account = new BankAccount(100);
                Console.Write("Enter withdrawal amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }




        //Task 2:

        static void LogicalImplementation()
        {
            int number;
            Console.WriteLine("Logical Implementation:");
            Console.Write("Enter a number: ");

            // Using int.TryParse to validate input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                Console.Write("Enter a number: ");
            }

            Console.WriteLine($"You entered: {number}\n");
        }

        static void TryCatchImplementation()
        {
            int number = 0;
            bool validInput = false;
            Console.WriteLine("Try-Catch Implementation:");

            // Using try-catch for input validation
            while (!validInput)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine($"You entered: {number}");
        }






        //Task 5:

        // Custom Exception
        public class InsufficientFundsException : Exception
        {
            public InsufficientFundsException(string message) : base(message) { }
        }

        // BankAccount Class
        public class BankAccount
        {
            public decimal Balance { get; private set; }
            private const decimal MinimumBalance = 10;

            public BankAccount(decimal initialBalance)
            {
                if (initialBalance < MinimumBalance)
                    throw new ArgumentException($"Initial balance must be at least {MinimumBalance}");
                Balance = initialBalance;
            }

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Deposit amount must be greater than zero.");
                Balance += amount;
                Console.WriteLine($"Deposited: ${amount}. Current Balance: ${Balance}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Withdrawal amount must be greater than zero.");
                if (Balance - amount < MinimumBalance)
                    throw new InsufficientFundsException($"Error: Insufficient funds. Minimum balance of ${MinimumBalance} must be maintained.");

                Balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. Current Balance: ${Balance}");
            }
        }





    }
}
