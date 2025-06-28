using System.Text.RegularExpressions;

namespace Utils
{
    public static class InputValidator
    {
        public static bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\+?[0-9\-]{7,15}$");
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        internal static string ReadNonEmptyString(string v)
        {
            throw new NotImplementedException();
        }
    }
}

