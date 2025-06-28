using System;
using ProductInventorySystem.Services;

namespace ProductInventorySystem
{
    class Program
    {
        static void Main()
        {
            ProductService service = new ProductService();
            int choice;

            do
            {
                Console.WriteLine("\n=== 🛒 Product Inventory System ===");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Search product by code");
                Console.WriteLine("4. Update product name");
                Console.WriteLine("5. Remove product");
                Console.WriteLine("6. Check if product exists by name");
                Console.WriteLine("7. Show product count");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("❌ Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1: service.AddProduct(); break;
                    case 2: service.ViewAll(); break;
                    case 3: service.SearchProduct(); break;
                    case 4: service.UpdateProduct(); break;
                    case 5: service.RemoveProduct(); break;
                    case 6: service.CheckProductByName(); break;
                    case 7: service.ShowCount(); break;
                    case 8: Console.WriteLine("👋 Exiting..."); break;
                    default: Console.WriteLine("❌ Invalid choice!"); break;
                }
            } while (choice != 8);
        }
    }
}
