using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWithArrayListPractice.Models
{
    public class Article : LibraryItem
    {
        public string JournalName { get; private set; }

        public Article(string title, string author, int publishYear, string journalName)
            : base(title, author, publishYear)
        {
            JournalName = journalName;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Journal Name: {JournalName}");
            Console.WriteLine(new string('-', 40)); // Add a separator line
        }

        public void UpdateJournalName(string newJournalName)
        {
            if (!string.IsNullOrWhiteSpace(newJournalName))
            {
                JournalName = newJournalName;
            }
        }
    }
}
