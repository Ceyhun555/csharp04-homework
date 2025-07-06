using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookManagementSystem.Constants
{
    public static class RegexPatterns
    {
        /// <summary>
        /// Regular expression pattern for validating phone number 
        /// 
        /// Pattern breakdown:
        /// - ^[\+]?- Start of string , optional plus sign
        /// - [1-9]- First digit must be 1-9 (no leading zero)
        /// - [\d]{0,15}- Followed 0 to 15 digits 
        /// -$- End of string 
        /// 
        /// Examples of valid phone number
        /// - +1234567890
        /// - 1234567890
        /// - +1-555-0123 (after removing seperators)
        /// </summary>
        public const string PhoneNumberPattern = @"^[\+]?[1-9][\d]{0,15}$";

        /// <summary>
        ///  Regular expression pattern for validating email addresses.
        ///  
        /// Pattern breakdown.
        /// - ^[^@\s]+ - Start of string, one or more characters that are not @ or whitespace
        /// - @ - literal symbol
        /// - [^@\s]+ - One or more characters that or not @ or whitespace (domain name)
        /// - \. - literal dot
        /// - [^@\s]+ - One or more characters that are not @ or whitespace (top-level domain)
        /// - $ - End of string 
        /// 
        /// Examples of valid email adress:
        /// - user@domain.com
        /// - test.email@subdomain.example.org
        /// -  user.tag@domain.co.uk
        /// </summary>
        public const string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

    }
}
