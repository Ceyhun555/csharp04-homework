using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public static class RegexValidator
    {

        private static readonly Regex _emailRegex = new(@"^[a-zA-Z0-9._%+-]{3,20}@[a-zA-Z0-9.-]{2,50}\.(com|org|net|edu)$", RegexOptions.Compiled);


        private static readonly Regex _phoneRegex = new(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", RegexOptions.Compiled);


        private static readonly Regex _nameRegex = new(@"^[a-zA-Z][a-zA-Z\s\-'\.]{0,48}[a-zA-Z]$", RegexOptions.Compiled);


        private static readonly Regex _passwordRegex = new(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", RegexOptions.Compiled);


        private static readonly Regex _dateRegex = new(@"^(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01])/(19|20)\d{2}$", RegexOptions.Compiled);


        public static bool IsValidEmail(string email)
        {
            /*
             * VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex pattern for performance
             * 3. Return true if pattern matches, false otherwise
             */

            if (string.IsNullOrWhiteSpace(email))
                return false;

            return _emailRegex.IsMatch(email);
        }


        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            /*
             * VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex pattern that captures groups
             * 3. Pattern automatically handles various separators
             * 4. Returns true if exactly 10 digits are found in correct format
             */

            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            return _phoneRegex.IsMatch(phoneNumber);
        }


        public static bool IsValidName(string name)
        {
            /*
             * VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex pattern that enforces start/end with letters
             * 3. Pattern allows common name characters and formatting
             * 4. Ensures proper name structure and length
             */

            if (string.IsNullOrWhiteSpace(name))
                return false;

            return _nameRegex.IsMatch(name);
        }


        public static bool IsStrongPassword(string password)
        {
            /*
             * VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex with positive lookaheads
             * 3. Each lookahead checks for one requirement without consuming characters
             * 4. Final pattern ensures minimum length and allowed characters
             */

            if (string.IsNullOrWhiteSpace(password))
                return false;

            return _passwordRegex.IsMatch(password);
        }


        public static bool IsValidDateFormat(string date)
        {
            /*
             * VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use regex pattern for format validation
             * 3. If regex passes, validate actual date existence
             * 4. Additional validation handles edge cases like February 30th
             */

            if (string.IsNullOrWhiteSpace(date))
                return false;

            if (!_dateRegex.IsMatch(date))
                return false;

            // Additional validation for specific month-day combinations
            return IsValidDate(date);
        }


        private static bool IsValidDate(string date)
        {
            /*
             * ADDITIONAL VALIDATION LOGIC:
             * 1. Use DateTime.TryParse for actual date validation
             * 2. Format parsed date back to MM/DD/YYYY format
             * 3. Compare with original to ensure proper formatting
             * 4. Handle exceptions gracefully
             */

            try
            {
                if (DateTime.TryParse(date, out DateTime parsedDate))
                {
                    // Check if the parsed date matches the original string format
                    string formattedDate = parsedDate.ToString("MM/dd/yyyy");
                    return date == formattedDate;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        public static string? FormatPhoneNumber(string phoneNumber)
        {
            /*
             * FORMATTING LOGIC:
             * 1. First validate the phone number format
             * 2. Remove all non-digit characters using regex
             * 3. Verify exactly 10 digits remain
             * 4. Format into standard (XXX) XXX-XXXX format
             * 5. Return null if validation fails
             */

            if (!IsValidPhoneNumber(phoneNumber))
                return null;

            // Remove all non-digit characters
            string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");

            if (digitsOnly.Length != 10)
                return null;

            // Format as (XXX) XXX-XXXX
            return $"({digitsOnly.Substring(0, 3)}) {digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6, 4)}";
        }



        public static string CleanText(string text)
        {
            /*
             * TEXT CLEANING LOGIC:
             * 1. Check for null or whitespace input
             * 2. Remove extra whitespace using regex
             * 3. Normalize line endings to \n
             * 4. Remove unwanted special characters
             * 5. Convert multiple punctuation to single
             * 6. Trim leading/trailing whitespace
             */

            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            // Remove extra whitespace
            text = Regex.Replace(text, @"\s+", " ");

            // Normalize line endings
            text = Regex.Replace(text, @"\r\n|\r|\n", "\n");

            // Remove special characters except letters, numbers, and basic punctuation
            text = Regex.Replace(text, @"[^\w\s\.\!\?\,\;\:\-\(\)]", "");

            // Convert multiple consecutive punctuation marks to single
            text = Regex.Replace(text, @"([\.\!\?\,\;\:\-\(\)])\1+", "$1");

            return text.Trim();
        }



        public static ArrayList ExtractEmails(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return new ArrayList();

            ArrayList emails = new ArrayList();
            var matches = _emailRegex.Matches(text);

            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }

            return emails;
        }



        public static bool[] ValidateEmails(string[] emails)
        {
            bool[] results = new bool[emails.Length];
            for (int i = 0; i < emails.Length; i++)
            {
                results[i] = IsValidEmail(emails[i]);
            }
            return results;
        }

    }
}
