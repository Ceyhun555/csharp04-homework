using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1: Count Characters in a String

            ////Description * *: Write a program that asks the user for a string and outputs the number of characters in it.

            //Console.WriteLine("Enter  a string: ");

            //string userInPut = Console.ReadLine();

            //Console.WriteLine("The number of characters: " + userInPut.Length);

            //Console.WriteLine();

            ////Task 2: Check if String Contains a Substring

            ///*Description: Write a program that prompts the user for two strings and checks
            //*if the second string is a substring of the first.Display an appropriate message.*/

            //Console.WriteLine("Enter sentence");

            //string sentence1 = Console.ReadLine();

            //Console.WriteLine("Enter sentence");

            //string sentence2 = Console.ReadLine();

            //bool containsSentence2 = sentence1.Contains(sentence2);

            //if (containsSentence2 == true)
            //{
            //    Console.WriteLine("Sentence2 is substring " + sentence1);
            //}
            //else
            //{
            //    Console.WriteLine("Sentence2 is not substring sentence1 ");
            //}

            //Console.WriteLine();


            ////Task 3: Convert to Uppercase:

            ////Description: Write a program that takes a string as input and converts it to uppercase.

            //Console.WriteLine("Enter country:");

            //string country = Console.ReadLine();

            //string upperCaseString = country.ToUpper();

            //Console.WriteLine("The uppercase version is: " + upperCaseString);

            ////Task 4: Count Vowels and Consonants

            ////Description: Write a program that asks the user for a string and counts the number of vowels and consonants in it.
            ////(a, e, i, o, u - case insensitive) 

            //Console.WriteLine("Enter Text");

            //string text = Console.ReadLine().ToLower();

            //int vowelCount = 0;

            //int consonantCount = 0;

            ////Salam Ceyhun necesen?
            ////Length 18

            //for (int i = 0; i < text.Length; i++)
            //{
            //    char characterOfText = text[i]; // 0:s,1:a,

            //    if (char.IsLetter(characterOfText)) //true 
            //    {
            //        if ("aeiou".Contains(characterOfText))
            //        {
            //            vowelCount++;
            //        }
            //        else if (characterOfText >= 'a' && characterOfText <= 'z')
            //        {
            //            consonantCount++;
            //        }

            //    }
            //}

            //Console.WriteLine("Number of vowels: " + vowelCount);

            //Console.WriteLine("Number of consonants: " + consonantCount);

            //Console.WriteLine();

            /*Task 5: Reverse a String
            Description: Write a program that takes a string as input and outputs it in reverse.

            Example Input and Output:

            Enter a string: OpenAI
            Output: IAnepO  */

            //Console.WriteLine("Enter a string");

            //string toReverseWithLoop = Console.ReadLine();

            //string reversedString = "";

            //for (int i = toReverseWithLoop.Length - 1; i >= 0; i--)
            //{
            //    reversedString += toReverseWithLoop[i];
            //}
            //Console.WriteLine($"Output (Loop): {reversedString}\n");

            //Console.WriteLine();

            ///*Task 6: Check if String is a Palindrome
            //Description: Write a program that checks if a string is a palindrome (reads the same forward and backward). Ignore case.

            //Example Input and Output:

            //Enter a string: Racecar
            //Output: The string is a palindrome.
            //Enter a string: Hello
            //Output: The string is not a palindrome.*/

            //Console.WriteLine("Enter string");

            //string input = Console.ReadLine();
            //bool isPalindrome = true;

            //for (int index = 0; index < input.Length / 2; index++)
            //{
            //    char currentChar = input[index]; // 0
            //    char endChar = input[input.Length - index - 1]; // 6
            //    if (currentChar != endChar)
            //    {
            //        Console.WriteLine($"{currentChar} != {endChar}");
            //        isPalindrome = false;
            //        break;

            //    }


            //}
            //if (isPalindrome == true)
            //{
            //    Console.WriteLine("The string is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("The string is not a palindrome");
            //}





            ///*Task 7: Count Words in a Sentence: Split  methodu istifade et.
            //Description: Write a program that takes a sentence as input and counts the number of words in it.

            //Example Input and Output:

            //Enter a sentence: This is a simple sentence.
            //Output: The sentence has 5 words.*/

            //Console.WriteLine("Enter sentence");

            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(new char[] { ' ', '\t' });

            //int wordCount = words.Length;

            //Console.WriteLine($"Word count: {wordCount}");

            //Console.WriteLine();





            ///*Task 8: Replace a Word in a String: Replace methodu istifade et/
            //Description: Write a program that prompts the user for a sentence and a word to replace within that sentence. Then ask for the replacement word and display the new sentence.

            //Example Input and Output:

            //Enter a sentence: I love coding
            //Enter the word to replace: coding
            //Enter the replacement word: programming
            //Output: New sentence: I love programming*/

            //Console.Write("Enter a sentence: ");

            //string sentence3 = Console.ReadLine();

            //Console.Write("Enter the word to replace: ");

            //string wordToReplace = Console.ReadLine();

            //Console.Write("Enter the replacement word: ");

            //string replacementWord = Console.ReadLine();

            //string newSentence = sentence3.Replace(wordToReplace, replacementWord);

            //Console.WriteLine("New sentence: " + newSentence);

            //Console.WriteLine();

            ///*Task 9: Extract Initials from a Full Name: Split methodu istifade et.
            //Description: Write a program that takes a full name (first, middle, and last name) as input and outputs the initials.

            //Example Input and Output:

            //Enter your full name: John Michael Doe
            //Output: Initials: J.M.D*/

            //Console.WriteLine("Enter your full name");

            //string fullName = Console.ReadLine();

            //string[] nameParts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //string initials = "";

            //foreach (string part in nameParts)
            //{
            //    initials += part[0] + ".";
            //}

            //Console.WriteLine("Initials: " + initials);

            //Console.WriteLine();



            ///*Task 10: Count Occurrences of a Character: Count methodu istifade et.
            //Description: Write a program that asks the user for a string and a character. The program should count how many times the character appears in the string.

            //Example Input and Output:

            //Enter a string: Mississippi
            //Enter a character to count: s
            //Output: The character 's' appears 4 times.*/

            //Console.Write("Enter a string");

            //string inputString = Console.ReadLine();

            //Console.Write("Enter a character to count");

            //char characterToCount = Console.ReadKey().KeyChar;

            //Console.WriteLine();

            //int count = 0;

            //foreach (char c in inputString)
            //{
            //    if (c == characterToCount)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"The character '{characterToCount}' appears {count} times in the string");

            //Console.WriteLine();


            /*Task 11: Remove Spaces from a String: Replace methodu istifade et.
            Description: Write a program that removes all spaces from a string entered by the user.

            Example Input and Output:

            Enter a string: Hello World
            Output: HelloWorld*/

            Console.WriteLine("Enter a words");

            string words4 = Console.ReadLine();

            string result = words4.Replace(" ", "");

            Console.WriteLine("String without spaces: " + result);

            Console.WriteLine();


            /*Task 12: Find the Longest Word in a Sentence: Split methodu
            Description: Write a program that takes a sentence as input and finds the longest word in the sentence.

            Example Input and Output:

            Enter a sentence: The quick brown fox jumps
            Output: The longest word is: jumps*/

            Console.WriteLine("Enter a sentence");

            string sentence5 = Console.ReadLine();

            string[] words5 = sentence5.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words5.OrderByDescending(word => word.Length).FirstOrDefault();

            Console.WriteLine("The longest words is: " + longestWord);

            Console.WriteLine();
            string longestWord2 = "";
            for (int i = 0; i <= words5.Length; i++)
            {
                if (words5[i].Length > longestWord2.Length)
                {
                    longestWord2 = words5[i];// Salam necesen ceyhun = 0: salam , 1: necesen, 2: ceyhun
                }
            }
            Console.WriteLine("The longest words is: " + longestWord2);


            /*Task 13: Capitalize Each Word: 
            Description: Write a program that takes a sentence as input and capitalizes the first letter of each word.

            Example Input and Output:

            Enter a sentence: welcome to the world of c#
            Output: Welcome To The World Of C#*/






            /*Task 14: Check if String Starts or Ends with a Specific Word
            Description: Write a program that asks the user for a sentence and a word.Check if the sentence starts or ends with the given word.

            Example Input and Output:

            Enter a sentence: Hello, welcome to C# programming.
            Enter the word to check: Hello
            Output: The sentence starts with 'Hello'.
            Enter a sentence: Welcome to C# programming.
            Enter the word to check: programming
            Output: The sentence ends with 'programming'.*/

            Console.Write("Enter a sentence: ");

            string sentence7 = Console.ReadLine();

            Console.Write("Enter the word to check: ");

            string word = Console.ReadLine();

            if (sentence7.StartsWith(word))
            {
                Console.WriteLine($"The sentence starts with '{word}'.");
            }
            else if (sentence7.EndsWith(word))
            {
                Console.WriteLine($"The sentence ends with '{word}'.");
            }
            else
            {
                Console.WriteLine($"The sentence does not start or end with '{word}'.");
            }
            Console.WriteLine();

            /*Task 15: Convert String to Title Case
            Description: Write a program that converts a string to title case (first letter of each word capitalized, rest lowercase).

            Example Input and Output:

            Enter a string: c# programming IS fun
            Output: C# Programming Is Fun*/









        }
    }
}
