using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public static class RegexValidator
    {

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]{3,20}@[a-zA-Z0-9.-]{2,50}\.(com|org|net|edu)$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsValidPhoneNumber(string phone)
        {
            string pattern = @"^(\(\d{3}\)|\d{3})[\s.-]?\d{3}[\s.-]?\d{4}$";
            return Regex.IsMatch(phone, pattern);
        }

        public static bool IsValidName(string name)
        {
            string pattern = @"^(?!.*[ .'-]{2})[a-zA-Z][a-zA-Z .'-]{0,48}[a-zA-Z]$";
            return Regex.IsMatch(name, pattern);
        }

        public static bool IsStrongPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        public static bool IsValidDateFormat(string date)
        {
            string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/(19|20)\d\d$";
            return Regex.IsMatch(date, pattern);


        }
    }
}
