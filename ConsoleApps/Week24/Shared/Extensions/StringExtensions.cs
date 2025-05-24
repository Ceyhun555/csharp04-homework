using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class StringExtension
    {
        public static int WordCount(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            char[] delimiters = { ' ', '.', ',', ';', ':', '!', '?', '\t', '\n', '\r' };
            string[] parts = input.Split(delimiters);

            int count = 0;

            foreach (string part in parts)
            {
                if (!string.IsNullOrWhiteSpace(part))
                {
                    count++;
                }
            }

            return count;
        }



        
        public static int WordCountWithoutSplit(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            char[] delimiters = { ' ', '.', ',', ';', ':', '!', '?', '\t', '\n', '\r' };


            return 0;
        }
    }
}
