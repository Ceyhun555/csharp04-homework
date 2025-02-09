using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegementSystem.Models
{
    internal class Article:LibraryItem
    {
        public string JournalName { get; private set; }

        public Article(string title, string author, int publishYear, string journalName ) :base(title, author, publishYear)
        {
            JournalName = journalName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"JournalName: {JournalName}");
        }

        public void UpdateJournalName(string newJournalName)
        {
            JournalName = newJournalName;
        }
    }
}
