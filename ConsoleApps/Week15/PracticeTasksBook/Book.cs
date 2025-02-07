using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasksBook
{
    internal class Book
    {
        public Book(string title = "Untitled", string author = "Unknown", int yearPublished = 2000, decimal price = 0.0m)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            Price = price;
        }

        public Book(string title, string author, int yearPublished)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            Price = 0.0m;
        }

        public Book(string title, int yearPublished, string author, decimal price):this(title, author, yearPublished) 
        {
            
            Price = price;


        }

        public string Title { get; set; }

        public string Author { get; set; }

        private int _yearPublished;
        public int YearPublished
        {
            get
            {
                return _yearPublished;
            }
            set
            {
                if (value > 0)
                {
                    _yearPublished = value;
                }
                else
                {
                    Console.WriteLine("YearPublished must be positive year (greater than 0).");
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
                    Console.WriteLine("Price must be greater than or equal to 0.");
                }
            }
        }



        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year Published: {YearPublished}, Price: {Price} ");
        }

        public void DiscountPrice(decimal discountPercentage)
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

        public void UpdateYearPublished(int newYear)
        {
            if (newYear <= 0)
            {
                Console.WriteLine("YearPublished must be greater than 0.");
            }
            else
            {
                YearPublished = newYear;
            }
        }
    }
}
