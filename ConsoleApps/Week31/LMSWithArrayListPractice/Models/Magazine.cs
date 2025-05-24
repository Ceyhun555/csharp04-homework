using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWithArrayListPractice.Models
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; private set; }

        public Magazine(string title, string author, int publishYear, int issueNumber)
            : base(title, author, publishYear)
        {
            IssueNumber = issueNumber;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Issue: {IssueNumber}");
            Console.WriteLine(new string('-', 40)); // Add a separator line
        }


        public void UpdateIssueNumber(int newIssueNumber)
        {
            if (newIssueNumber > 0)
            {
                IssueNumber = newIssueNumber;
            }
        }
    }
}
