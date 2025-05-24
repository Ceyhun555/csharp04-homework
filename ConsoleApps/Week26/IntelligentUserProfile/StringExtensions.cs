using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentUserProfile
{
    public static class StringExtensions
    {
        public static int WordCount(this string input)
        {
            return string.IsNullOrWhiteSpace(input) ? 0 : input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ToTitleCase(this string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}
