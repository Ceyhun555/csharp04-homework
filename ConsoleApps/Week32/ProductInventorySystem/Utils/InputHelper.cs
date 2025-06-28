using System;

namespace ProductInventorySystem.Utils
{
    public static class InputHelper
    {
        public static string ReadNonEmpty(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine().Trim();
            } while (string.IsNullOrEmpty(input));

            return input;
        }
    }
}

