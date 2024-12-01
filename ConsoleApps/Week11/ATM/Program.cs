using System;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ATM variables.
            int correctPin = 2024;
            int balance = 5000;
            bool isAuthenticated = false;
            int maxAttempts = 3;

            // Task 1: PIN Authentication
            /*
             * Description:
             * Prompt the user to enter a PIN. Allow up to 3 attempts for correct PIN entry.
             *
             * Explanation:
             * Use a `for` loop to give the user 3 attempts. If the correct PIN is entered, set
             * `isAuthenticated` to true. If all attempts fail, display an error message.
             */

            for (int attempts = 1; attempts <= maxAttempts; attempts++)
            {
                Console.WriteLine("Enter PIN: ");
                if (int.TryParse(Console.ReadLine(), out int enteredPin) && enteredPin == correctPin)
                {
                    isAuthenticated = true;
                    Console.WriteLine("Access granted.\n");
                    break;
                }
                Console.WriteLine($"Incorrect PIN. You have {maxAttempts - attempts} attempts reamining.");
            }
            if (isAuthenticated)
            {
                Console.WriteLine("To many incorrect attepmts. Access denied.");
                return;
            }


            // Task 2: ATM Main Menu
            /*
             * Description:
             * Display a menu with options for checking balance, depositing, withdrawing, and exiting.
             *
             * Explanation:
             * Use a `do-while` loop to display the menu repeatedly until the user chooses to exit.
             */

            bool exit = false;
            do
            {
                Console.WriteLine("\nATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (choice)
                {
                    // Task 3: Check Balance
                    case 1:
                        Console.WriteLine($"Your balance is ${balance}");
                        break;
                    
                    case 2:
                        // Task 4: Deposit Money
                        Console.WriteLine("Enter a amount to deposit: ");
                        if (int.TryParse(Console.ReadLine(), out int depositAmount) && depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"${depositAmount} deposited succesfully. Your new balance is ${balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive value.");
                        }
                        break;

                    case 3:
                        // Task 5: Withdraw Money with Denominations
                        Console.Write("Enter amount to withdraw: ");
                        if (!int.TryParse(Console.ReadLine(), out int withdrawAmount) || withdrawAmount <= 0)
                        {
                            Console.WriteLine("Invalid amount. Please enter a postive value. ");
                            break;
                        }
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        else
                        {
                            int remainingAmount = withdrawAmount;
                            int[] denominations = { 100, 50, 20, 10, 5, 1 };
                            Console.WriteLine("Dispensing cash:");

                            foreach (int denomination in denominations)
                            {
                                int count = remainingAmount / denomination;
                                if (count > 0)
                                {
                                    Console.WriteLine($"${denomination} bills: {count}");
                                    remainingAmount %= denomination;
                                }
                            }

                            balance -= withdrawAmount;
                            Console.WriteLine($"Remaining balance: ${balance}");
                        }
                        break;

                    case 4:
                        // Task 6: Exit ATM
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                        break;
                }
            } while (!exit);

        }











    }

}

