using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Tasks.Product
{

    class Program
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            BasicProduct book = new BasicProduct("Book", 20.0, 10);
            DigitalProduct ebook = new DigitalProduct("E-Book", 10.0);
            PhysicalProduct laptop = new PhysicalProduct("Laptop", 800.0, 5, 20.0);

            cart.AddToCart(book, 2);
            cart.AddToCart(ebook, 1);
            cart.AddToCart(laptop, 1);

            cart.ApplyDiscount(5);
            Console.WriteLine("Total before tax: " + cart.CalculateTotal());
            cart.Checkout();
        }
    }



    interface IProduct
    {
        string Name { get; }
        double Price { get; }
        int Stock { get; set; }
    }

    // Interface for shopping cart operations
    interface IShoppingCart
    {
        void AddToCart(IProduct product, int amount);
        void RemoveFromCart(IProduct product, int amount);
        double CalculateTotal();
        void ApplyDiscount(double percentage);
        double CalculateTax(double taxRate);
        void Checkout();
    }

    // Basic product class
    class BasicProduct : IProduct
    {
        public string Name { get; }
        public double Price { get; }
        public int Stock { get; set; }

        public BasicProduct(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    // Digital product class
    class DigitalProduct : IProduct
    {
        public string Name { get; }
        public double Price { get; }
        public int Stock { get; set; } = int.MaxValue; // Unlimited stock

        public DigitalProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    // Physical product class
    class PhysicalProduct : IProduct
    {
        public string Name { get; }
        public double Price { get; }
        public int Stock { get; set; }
        public double ShippingCost { get; }

        public PhysicalProduct(string name, double price, int stock, double shippingCost)
        {
            Name = name;
            Price = price;
            Stock = stock;
            ShippingCost = shippingCost;
        }
    }

    // Shopping cart class
    class ShoppingCart : IShoppingCart
    {
        private double total = 0;

        public void AddToCart(IProduct product, int amount)
        {
            if (product.Stock >= amount)
            {
                total += product.Price * amount;
                product.Stock -= amount;
                Console.WriteLine(amount + " " + product.Name + " added to cart.");
            }
            else
            {
                Console.WriteLine("Not enough stock for " + product.Name);
            }
        }

        public void RemoveFromCart(IProduct product, int amount)
        {
            total -= product.Price * amount;
            product.Stock += amount;
            Console.WriteLine(amount + " " + product.Name + " removed from cart.");
        }

        public double CalculateTotal()
        {
            return total;
        }

        public void ApplyDiscount(double percentage)
        {
            total -= total * (percentage / 100);
            Console.WriteLine("Discount applied: " + percentage + "%");
        }

        public double CalculateTax(double taxRate)
        {
            return total * (taxRate / 100);
        }

        public void Checkout()
        {
            Console.WriteLine("Total after tax: " + (total + CalculateTax(10))); // Example tax rate 10%
            Console.WriteLine("Order placed successfully!");
        }
    }
}
