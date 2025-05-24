using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass.Tasks
{
    public static class StringHelper
    {
        /// <summary>
        /// racecar -> racecar -> ['r', 'a', 'c', 'e', 'c', 'a', 'r']
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //public static bool IsPalindrome(string input)
        //{
        //    string reversed = new string(input.ToLower().ToCharArray().Reverse().ToArray());
        //    return input.ToLower() == reversed;
        //}


        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string cleaned = input.Replace(" ", "").ToLower();
            int length = cleaned.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (cleaned[i] != cleaned[length - 1 - i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// "hello world" -> "Hello World"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //public static string ToTitleCase(string input)
        //{

        //    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        //    return textInfo.ToTitleCase(input.ToLower());
        //}


        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            StringBuilder result = new StringBuilder(input.Length);
            string[] words = input.ToLower().Split(' ');

            foreach (string word in words)
            {
                if (word.Length > 0)
                    result.Append(char.ToUpper(word[0]) + word.Substring(1) + " ");
            }

            return result.ToString().TrimEnd();
        }
    }
}
