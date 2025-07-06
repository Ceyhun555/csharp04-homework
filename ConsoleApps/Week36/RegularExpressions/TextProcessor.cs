using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public static class TextProcessor
    {
        public static ArrayList ExtractEmails(string text)
        {
            ArrayList emails = new ArrayList();
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|org|net|edu)";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match m in matches)
                emails.Add(m.Value);

            return emails;
        }

        public static string? FormatPhoneNumber(string input)
        {
           
        }

        public static string CleanText(string input)
        {
            
        }
    }
}
