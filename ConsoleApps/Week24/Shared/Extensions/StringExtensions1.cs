using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class StringExtensions
    {
        public static int WordCount1(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            int count = 0;
            bool inWord = false;

            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            return count;
        }
    }
}
