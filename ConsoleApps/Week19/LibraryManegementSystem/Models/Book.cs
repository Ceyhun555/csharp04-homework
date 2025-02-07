using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegementSystem.Models
{
    internal class Book :LibraryItem
    {
        public string Genre { get; private set; }

        public Book(string title, string author, int publishYear, string genre) :base(title, author, publishYear)
        {
            Genre = genre;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
