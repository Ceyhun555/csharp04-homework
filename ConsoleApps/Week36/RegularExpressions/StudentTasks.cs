using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public static  class StudentTasks
    {
        public static bool IsValidCreditCard(string cardNumber)
        {
            // TODO: Implement credit card validation
            // 1. Check for null or empty input
            // 2. Remove all non-digit characters (spaces, hyphens, etc.)
            // 3. Check if the cleaned number starts with 3, 4, 5, or 6
            // 4. Check if the length is between 13 and 19 digits
            // 5. Return true if all conditions are met

            throw new NotImplementedException("You need to implement this method");
        }

        public static bool IsValidIpAddress(string ipAddress)
        {
            // TODO: Implement IP address validation
            // 1. Check for null or empty input
            // 2. Split by dots and check for exactly 4 parts
            // 3. For each octet:
            //    - Must be a valid number
            //    - Must be between 0 and 255
            //    - Must not have leading zeros (except 0 itself)
            // 4. Return true if all conditions are met

            throw new NotImplementedException("You need to implement this method");
        }



        public static bool IsValidTime(string time)
        {
            // TODO: Implement time format validation
            // 1. Check for null or empty input
            // 2. Check if the format is HH:MM (exactly 5 characters with colon in middle)
            // 3. Extract hours and minutes
            // 4. Validate hours (00-23)
            // 5. Validate minutes (00-59)
            // 6. Return true if all conditions are met

            throw new NotImplementedException("You need to implement this method");
        }



        public static bool IsValidZipCode(string zipCode)
        {
            // TODO: Implement ZIP code validation
            // 1. Check for null or empty input
            // 2. Check if the format matches either:
            //    - Exactly 5 digits: "12345"
            //    - 5 digits + hyphen + 4 digits: "12345-6789"
            // 3. Ensure only digits and optional hyphen are present
            // 4. Return true if format is valid

            throw new NotImplementedException("You need to implement this method");
        }



        public static string? FormatCreditCard(string cardNumber)
        {
            // TODO: Implement credit card formatting
            // 1. Check for null or empty input
            // 2. Remove all non-digit characters
            // 3. Check if the cleaned number has 13-19 digits
            // 4. Format into groups of 4 digits separated by hyphens
            // 5. Return formatted string or null if invalid

            throw new NotImplementedException("You need to implement this method");
        }



        public static int[] ExtractNumbers(string text)
        {
            // TODO: Implement number extraction
            // 1. Check for null or empty input
            // 2. Use regex to find all numbers in the text
            // 3. Convert found numbers to integers
            // 4. Return array of integers
            // 
            // Hint: You can use regex pattern @"\d+" to find sequences of digits
            // or @"\d+(?:\.\d+)?" to find both integers and decimals

            throw new NotImplementedException("You need to implement this method");
        }



        public static Hashtable CountWordFrequency(string text)
        {
            // TODO: Implement word frequency counting (Bonus task)
            // 1. Check for null or empty input
            // 2. Split text into words
            // 3. Clean each word (remove punctuation, convert to lowercase)
            // 4. Count frequency of each word
            // 5. Return Hashtable with word as key and count as value

            throw new NotImplementedException("You need to implement this method");
        }
    }
}
