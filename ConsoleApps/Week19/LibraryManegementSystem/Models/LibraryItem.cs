using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegementSystem.Models
{
    public class LibraryItem
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

        public int PublishYear { get; private set; }

        public LibraryItem(string title, string author, int publishYear)
        {
            Title = title;
            Author = author;
            PublishYear = publishYear;
        }

        public virtual void  DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, PublishYear: {PublishYear}");
        }

        public void UpdateDetails(string newTitle, string newAuthor, int newPublishYear)
        {
            Title = newTitle;
            Author = newAuthor;
            PublishYear = newPublishYear;
        }
    }
}
