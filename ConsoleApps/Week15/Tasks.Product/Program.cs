namespace Tasks.Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Product Class Demonstration ===");

            // Create a Default Product
            Product defaultProduct = new Product();
            defaultProduct.DisplayDetails();




            // Create a Custom Product
            Product customProduct = new Product("Smartphone", "Electronics");
            customProduct.DisplayDetails();




            // Create a Fully Custom Product
            Product fullyCustomProduct = new Product("Laptop", "Electronics", 999.99m, 10);
            fullyCustomProduct.DisplayDetails();




            // Apply a discount
            fullyCustomProduct.ApplyDiscount(10);
            Console.WriteLine($"The price after a 10% discount is: ${fullyCustomProduct.Price}");




            // Change the price
            fullyCustomProduct.ChangePrice(799.99m);
            Console.WriteLine($"The price has been updated to: ${fullyCustomProduct.Price}");




            // Update the stock
            fullyCustomProduct.UpdateStock(10);
            Console.WriteLine($"10 units have been added to stock. Current stock: {fullyCustomProduct.Stock}");





            // Display final details
            fullyCustomProduct.DisplayDetails();
        }
    }
}
