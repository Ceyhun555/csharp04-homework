using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TasksCar
{
    internal class Car
    {
        //Default constructor.
        public Car(string make = "Unknown", string model = "Unknown", int year = 2000, decimal price = 10000.0m)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        //Parametrized constructor1.
        public Car(string make, int year, string model)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = 10000.0m;
        }

        //Parametrized constructor2.
        public Car(string model, decimal price, int year, string make):this(make,model, year)
        {
           
            Price = price;
            
            
        }


        public string Make { get; set; }


        public string Model { get; set; }


        private int _year;

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 0)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Year must be greater than 0.");
                }
            }
        }


        private decimal _price;


        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0.0m)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price must be greater than or equal to 0.0");
                }
            }
        }



        public void DisplayDetails()
        {
            
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
        }


        public void ApplyDiscount(decimal discountPercentage)
        {
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                Console.WriteLine("Discount percentage must be between 0 and 100");
            }
            else
            {
                Price = Price - ((Price * discountPercentage) / 100) ;
                Console.WriteLine($"{this.Make}: The price after applying 10% discount is: {this.Price}");
            }
        }



        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                Console.WriteLine("Price must be greater than or equal to 0.");
            }
            else
            {
                Price = newPrice;
                Console.WriteLine($"{this.Make}:The car's price has been updated to: ${this.Price}");
            }
        }


        public int AgeOfCar()
        {
            return DateTime.Now.Year - Year;
        }


    }
}
