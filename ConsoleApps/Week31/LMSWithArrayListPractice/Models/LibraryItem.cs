using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWithArrayListPractice.Models
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
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"[Item] Title: {Title}, Author: {Author}, Year: {PublishYear}");
        }

        public void UpdateDetails(string newTitle, string newAuthor, int newPublishYear)
        {
            if (!string.IsNullOrWhiteSpace(newTitle))
                Title = newTitle;

            if (!string.IsNullOrWhiteSpace(newAuthor))
                Author = newAuthor;

            if (newPublishYear >= 1000 && newPublishYear <= DateTime.Now.Year)
                PublishYear = newPublishYear;
        }
    }
}
