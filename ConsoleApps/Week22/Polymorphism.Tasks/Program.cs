﻿

using Polymorphism.Tasks.Payment;

namespace Polymorphism.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism Practice Tasks\n");

            // Task 2: Testing Payment Processor
            Console.WriteLine("Task 2: Payment Processor Demo");
            Console.WriteLine("------------------------------");
            var paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessPayment("1234-5678-9012-3456", 100.50);
            paymentProcessor.ProcessPayment("9876543210", "087654321", 500.75);
            paymentProcessor.ProcessPayment(50.25);
            Console.WriteLine();

            /*
            * The following section demonstrates dynamic polymorphism using an array of Employee objects.
            * It shows how different employee types can be stored in the same array and how the appropriate
            * CalculateSalary method is called based on the actual type of each employee at runtime.
            */
            Console.WriteLine("Task 3 & 4: Employee Salary Calculations");
            Console.WriteLine("---------------------------------------");
            Employee[] employees = new Employee[5];

            employees[0] = new FullTimeEmployee { Name = "John Doe", MonthlySalary = 5000 };
            employees[1] = new PartTimeEmployee { Name = "Jane Smith", HourlyRate = 20, HoursWorked = 80 };
            employees[2] = new FullTimeEmployee { Name = "Bob Johnson", MonthlySalary = 6000 };
            employees[3] = new PartTimeEmployee { Name = "Alice Brown", HourlyRate = 25, HoursWorked = 60 };
            employees[4] = new FullTimeEmployee { Name = "Charlie Wilson", MonthlySalary = 5500 };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}'s Salary: ${employee.CalculateSalary()}");
            }
            Console.WriteLine();

            /*
            * The following section demonstrates polymorphism in the product inventory system.
            * It shows how different types of products can be created and managed while maintaining
            * their specific attributes and behaviors. The DisplayDetails method demonstrates how
            * each product type can display its information in a specialized way.
            */
            Console.WriteLine("Task 5: Product System Demo");
            Console.WriteLine("--------------------------");
            var laptop = new Electronics
            {
                Name = "Gaming Laptop",
                Price = 1299.99,
                WarrantyPeriod = 24
            };

            var tShirt = new Clothing
            {
                Name = "Cotton T-Shirt",
                Price = 19.99,
                Size = "L"
            };

            var apple = new Food
            {
                Name = "Organic Apples",
                Price = 4.99,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            laptop.DisplayDetails();
            Console.WriteLine();
            tShirt.DisplayDetails();
            Console.WriteLine();
            apple.DisplayDetails();
        }
    }
}
