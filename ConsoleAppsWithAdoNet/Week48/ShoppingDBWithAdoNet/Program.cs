using OrderManagement.Enums;
using OrderManagement.Models;
using OrderManagement.Services;
using System;

namespace OrderManagement
{
    internal class Program
    {
        private const string ConnectionString =
            "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=OrderManagementDB;Integrated Security=True;Encrypt=False";

        private static readonly DatabaseManager _dbManager = new(ConnectionString);

        static void Main()
        {
            try { RunApplication(); }
            catch (Exception ex)
            {
                Console.WriteLine($"Application error: {ex.Message}");
                Console.ReadKey();
            }
        }

        private static void RunApplication()
        {
            bool running = true;
            while (running)
            {
                DisplayMenu();
                running = ProcessMenuChoice();
            }
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Order Management System ===");
            Console.WriteLine("1. Create Customer");
            Console.WriteLine("2. View Customers");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. Delete Customer");
            Console.WriteLine("5. Create Product");
            Console.WriteLine("6. View Products");
            Console.WriteLine("7. Update Product");
            Console.WriteLine("8. Delete Product");
            Console.WriteLine("9. Create Order");
            Console.WriteLine("10. View Orders");
            Console.WriteLine("11. Update Order Status");
            Console.WriteLine("12. Delete Order");
            Console.WriteLine("99. Exit");
            Console.Write("Select an option: ");
        }

        private static bool ProcessMenuChoice()
        {
            return int.TryParse(Console.ReadLine(), out int choice)
                ? HandleMenuOption((MenuOption)choice)
                : HandleInvalidInput();
        }

        private static bool HandleMenuOption(MenuOption option)
        {
            switch (option)
            {
                // eyni switch, bütün CRUD əməliyyatları
                case MenuOption.Exit: return false;
                default: return HandleInvalidInput();
            }
        }

        private static bool HandleInvalidInput()
        {
            Console.WriteLine("Invalid option!");
            Console.ReadKey();
            return true;
        }
    }
}