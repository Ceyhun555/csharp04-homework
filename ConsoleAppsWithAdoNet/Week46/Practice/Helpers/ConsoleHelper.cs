using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Helpers
{
    public static class ConsoleHelper
    {
        public static int ReadInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        public static decimal ReadDecimal(string message)
        {
            decimal value;
            while (true)
            {
                Console.Write(message);
                if (decimal.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid decimal. Try again.");
            }
        }

        public static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine()?.Trim();
                if (!string.IsNullOrWhiteSpace(input))
                    return input;

                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}
