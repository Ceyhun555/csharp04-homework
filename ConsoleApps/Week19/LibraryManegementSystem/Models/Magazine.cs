using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManegementSystem.Models
{
    internal class Magazine :LibraryItem
    {
        public int IssueNumber { get; private set; }

        public Magazine(string title, string author, int publishYear, int issueNumber) :base(title, author, publishYear)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"IssueNumber: {IssueNumber}");
        }

        public void UpdateIssueNumber(int newIssueNumber)
        {
            IssueNumber = newIssueNumber;
        }
    }
}
