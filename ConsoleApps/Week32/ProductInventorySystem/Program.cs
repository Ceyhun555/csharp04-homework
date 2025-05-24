using System.Collections;
using System.Globalization;

namespace ProductInventorySystem
{
    public class Program
    {
        static Hashtable inventory = new Hashtable();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Product Inventory System ===");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Search product by code");
                Console.WriteLine("4. Update product name");
                Console.WriteLine("5. Remove product");
                Console.WriteLine("6. Check if product exists by name");
                Console.WriteLine("7. Show product count");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        ViewProduct();
                        break;
                    case "3":
                        SearchProduct();
                        break;
                    case "4":
                        UpdateProduct();
                        break;
                    case "5":
                        RemoveProduct();
                        break;
                    case "6":
                        ChechProductNameExists();
                        break;
                    case "7":
                        Console.WriteLine($"Total Products: {inventory.Count}");
                        break;
                    case "8":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.Write("Enter Product Code: ");
            string code = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                Console.WriteLine("Code cannot be empty.");
                return;
            }

            if (inventory.ContainsKey(code))
            {
                Console.WriteLine("Product code already exists.");
                return;
            }

            Console.Write("Enter Product Name :");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            inventory[code] = name;
            Console.WriteLine("Product added!");

        }

        static void ViewProduct()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("No products in inventory.");
                return;
            }

            Console.WriteLine("All products (sorted by code): ");



        }

        static void SearchProduct()
        {
            Console.Write("Enter Product Code to search: ");
            string code = Console.ReadLine().Trim().ToUpper();

            if (inventory.ContainsKey(code))
            {
                Console.WriteLine($"Product found: {inventory[code]}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void UpdateProduct()
        {
            Console.WriteLine("Enter Product Code to update: ");
            string code = Console.ReadLine().Trim().ToUpper();

            if (!inventory.ContainsKey(code))
            {
                Console.WriteLine("Product code not found.");
                return;
            }

            Console.WriteLine("Enter New Product Name: ");
            string newName = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Product name cannot be empty.");
                return;
            }

            inventory[code] = newName;
            Console.WriteLine("Product updated!");

        }

        static void RemoveProduct()
        {
            Console.Write("Enter Product Code to remove: ");
            string code = Console.ReadLine().Trim().ToUpper();

            if (inventory.ContainsKey(code))
            {
                inventory.Remove(code);
                Console.WriteLine("Product removed.");
            }
            else
            {
                Console.WriteLine("Product code not found.");
            }
        }

        static void ChechProductNameExists()
        {
            Console.Write("Enter Product Name to check: ");
            string name = Console.ReadLine().Trim();

            if (inventory.ContainsValue(name))
            {
                Console.WriteLine("Product exists.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void ShowCount()
        {
            Console.WriteLine($"Total products in inventory: {inventory.Count}");
        }
    }
}
