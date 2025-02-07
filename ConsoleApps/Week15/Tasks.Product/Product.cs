using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Product
{
    internal class Product
    {
        public Product(string name = "Unnamed Product", string category = "General", decimal price = 0.0m, int stock = 0)
        {
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }



        public Product(string category, string name)
        {
            Category = category;
            Name = name;
            Price = 0.0m;
            Stock = 0;
        }

        public Product(decimal price, int stock, string category, string name):this(category, name)
        {
            Price = price;
            Stock = stock;
            
        }

        public string Name { get; set; }


        public string Category { get; set; }


        private decimal _price;

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0.0m)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price must be greater than or equal to 0.0");
                }
            }
        }



        private decimal _stock;

        public decimal Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                if(value > 0)
                {
                    _stock = value;
                }
                else
                {
                    Console.WriteLine("Stock must be greater than 0.");
                }
            }
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Category: {Category}, Price: {Price}, Stock: {Stock}");
        }


        public void ApplyDiscount(decimal discountPercentage)
        {
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                Console.WriteLine("Discount percentage must be between 0 and 100");
            }
            else
            {
                Price -= Price * (discountPercentage / 100);
            }
        }



        public void ChangePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                Console.WriteLine("Price must be greater than or equal to 0.");
            }
            else
            {
                Price = newPrice;
            }
        }



        public void UpdateStock(int quantity)
        {
            if (Stock + quantity < 0)
            {
                Console.WriteLine("Stock must not become negative.");
            }
            else
            {
                Stock += quantity;
            }
        }




    }
}
