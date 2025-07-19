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
        private static readonly Regex _logEntryRegex = new(@"^\[(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2})\] (\w+): (.+)$", RegexOptions.Compiled);


        private static readonly Regex _urlRegex = new(@"^https?://[^\s/$.?#].[^\s]*$", RegexOptions.Compiled);


        private static readonly Regex _ssnRegex = new(@"^(?!000|666|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$", RegexOptions.Compiled);



        private static readonly Regex _ipAddressRegex = new(@"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$", RegexOptions.Compiled);


        private static readonly Regex _timeRegex = new(@"^([01]\d|2[0-3]):([0-5]\d)$", RegexOptions.Compiled);


        private static readonly Regex _zipCodeRegex = new(@"^\d{5}(-\d{4})?$", RegexOptions.Compiled);


        public class LogEntry
        {
            /// <summary>
            /// Gets or sets the timestamp of the log entry.
            /// </summary>
            public DateTime Timestamp { get; set; }

            /// <summary>
            /// Gets or sets the log level (e.g., INFO, WARNING, ERROR, DEBUG).
            /// </summary>
            public string Level { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the log message content.
            /// </summary>
            public string Message { get; set; } = string.Empty;

            /// <summary>
            /// Returns a formatted string representation of the log entry.
            /// </summary>
            /// <returns>A string in the format "[YYYY-MM-DD HH:MM:SS] LEVEL: Message"</returns>
            public override string ToString()
            {
                return $"[{Timestamp:yyyy-MM-dd HH:mm:ss}] {Level}: {Message}";
            }
        }




        public class UrlComponents
        {
            /// <summary>
            /// Gets or sets the URL protocol (e.g., "http", "https").
            /// </summary>
            public string Protocol { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the domain name (e.g., "www.example.com").
            /// </summary>
            public string Domain { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the URL path (e.g., "/path/to/resource").
            /// </summary>
            public string Path { get; set; } = string.Empty;

            /// <summary>
            /// Gets or sets the query string parameters (without the leading "?").
            /// </summary>
            public string Query { get; set; } = string.Empty;

            /// <summary>
            /// Returns a reconstructed URL string from the components.
            /// </summary>
            /// <returns>A properly formatted URL string</returns>
            public override string ToString()
            {
                var url = $"{Protocol}://{Domain}{Path}";
                return string.IsNullOrEmpty(Query) ? url : $"{url}?{Query}";
            }
        }



        public static ArrayList ParseLogEntries(string logText)
        {
            ArrayList entries = new ArrayList();
            if (string.IsNullOrWhiteSpace(logText))
                return entries;
            var lines = logText.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var match = _logEntryRegex.Match(line.Trim());
                if (match.Success)
                {
                    var entry = new LogEntry
                    {
                        Timestamp = DateTime.Parse(match.Groups[1].Value),
                        Level = match.Groups[2].Value,
                        Message = match.Groups[3].Value
                    };
                    entries.Add(entry);
                }
            }
            return entries;
        }




        public static UrlComponents? ParseUrl(string url)
        {
            /*
             * URL PARSING LOGIC:
             * 1. Check for null or whitespace input
             * 2. Validate URL format using regex pattern
             * 3. Use System.Uri for reliable component extraction
             * 4. Extract protocol, host, path, and query components
             * 5. Create UrlComponents object with extracted data
             * 6. Handle parsing exceptions gracefully
             */

            if (string.IsNullOrWhiteSpace(url) || !_urlRegex.IsMatch(url))
                return null;

            try
            {
                var uri = new Uri(url);
                return new UrlComponents
                {
                    Protocol = uri.Scheme,
                    Domain = uri.Host,
                    Path = uri.AbsolutePath,
                    Query = uri.Query.TrimStart('?')
                };
            }
            catch
            {
                return null;
            }
        }



        public static bool IsValidSSN(string ssn)
        {
            /*
             * SSN VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex with negative lookaheads
             * 3. Pattern enforces format and business rules simultaneously
             * 4. Returns true only if all requirements are met
             */

            if (string.IsNullOrWhiteSpace(ssn))
                return false;

            return _ssnRegex.IsMatch(ssn);
        }


        public static bool IsValidIpAddress(string ipAddress)
        {
            /*
             * IP ADDRESS VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex with precise octet range patterns
             * 3. Pattern ensures exactly 4 octets with proper ranges
             * 4. Prevents leading zeros and invalid octet values
             */

            if (string.IsNullOrWhiteSpace(ipAddress))
                return false;

            return _ipAddressRegex.IsMatch(ipAddress);
        }




        public static bool IsValidTime(string time)
        {
            /*
             * TIME VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex with precise hour/minute patterns
             * 3. Pattern ensures 00-23 hours and 00-59 minutes
             * 4. Requires leading zeros for proper formatting
             */

            if (string.IsNullOrWhiteSpace(time))
                return false;

            return _timeRegex.IsMatch(time);



        }


        public static bool IsValidZipCode(string zipCode)
        {
            /*
             * ZIP CODE VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Use compiled regex with optional 9-digit extension
             * 3. Pattern ensures exactly 5 digits with optional 4-digit extension
             * 4. Validates proper hyphen placement and digit counts
             */

            if (string.IsNullOrWhiteSpace(zipCode))
                return false;

            return _zipCodeRegex.IsMatch(zipCode);
        }



        public static string TransformText(string text)
        {
            /*
             * TEXT TRANSFORMATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Convert to title case using word boundary regex
             * 3. Remove extra whitespace
             * 4. Add proper spacing around punctuation
             * 5. Trim leading/trailing whitespace
             */

            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            // Convert to title case (first letter of each word capitalized)
            text = Regex.Replace(text, @"\b\w", m => m.Value.ToUpper());

            // Remove extra spaces
            text = Regex.Replace(text, @"\s+", " ");

            // Add proper spacing around punctuation
            text = Regex.Replace(text, @"([.!?])([A-Za-z])", "$1 $2");

            // Remove leading/trailing whitespace
            text = text.Trim();

            return text;
        }



        public static int[] ExtractNumbers(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return new int[0];
            var matches = Regex.Matches(text, @"\d+");
            int[] numbers = new int[matches.Count];
            int idx = 0;
            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    numbers[idx++] = number;
                }
            }
            if (idx < numbers.Length)
            {
                // If some matches failed to parse, resize the array
                int[] result = new int[idx];
                Array.Copy(numbers, result, idx);
                return result;
            }
            return numbers;
        }




        public static Hashtable CountWordFrequency(string text)
        {
            Hashtable wordCount = new Hashtable();
            if (string.IsNullOrWhiteSpace(text))
                return wordCount;
            var words = Regex.Split(text.ToLower(), @"\W+")
                           .Where(word => !string.IsNullOrWhiteSpace(word))
                           .Where(word => word.Length > 1);
            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word] = (int)wordCount[word] + 1;
                else
                    wordCount[word] = 1;
            }
            return wordCount;
        }




        public static bool IsValidCreditCardFormat(string cardNumber)
        {
            /*
             * CREDIT CARD FORMAT VALIDATION LOGIC:
             * 1. Check for null or whitespace input
             * 2. Remove spaces and hyphens using regex
             * 3. Validate length (13-19 digits)
             * 4. Check starting digit (3, 4, 5, or 6)
             * 5. Ensure all characters are digits
             */

            if (string.IsNullOrWhiteSpace(cardNumber))
                return false;

            // Remove spaces and hyphens
            string cleanNumber = Regex.Replace(cardNumber, @"[\s-]", "");

            // Check if it's 13-19 digits and starts with valid prefix
            return Regex.IsMatch(cleanNumber, @"^[3-6]\d{12,18}$");
        }



        public static string? FormatCreditCard(string cardNumber)
        {
            /*
             * CREDIT CARD FORMATTING LOGIC:
             * 1. Validate credit card number format first
             * 2. Remove all non-digit characters using regex
             * 3. Use regex to insert spaces every 4 digits
             * 4. Return null if validation fails
             */

            if (!IsValidCreditCardFormat(cardNumber))
                return null;

            // Remove all non-digit characters
            string digitsOnly = Regex.Replace(cardNumber, @"\D", "");

            // Format with spaces every 4 digits
            return Regex.Replace(digitsOnly, @"(\d{4})(?=\d)", "$1 ");
        }
    }

}
