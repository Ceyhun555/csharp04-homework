using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*Task 1: Print Multiplication Table Using a For Loop
            Description: Write a program that prompts the user to enter a number, then prints the multiplication table for that number up to 10.

            Explanation:

            Use a for loop to iterate from 1 to 10 and multiply the user’s input by each value in the loop.
            Sample Input and Output:

            Enter a number: 5
            Output:
            5 x 1 = 5
            5 x 2 = 10
            5 x 3 = 15
            ...
            5 x 10 = 50
            Task*/


            int number;

            while (true)
            {
                Console.WriteLine("Enter a number");

                bool isValidParsing = int.TryParse(Console.ReadLine(), out number);
                if (isValidParsing == true)
                {
                    break;
                }
                Console.WriteLine("Enter valid a number");
            }

            Console.WriteLine($"Multiplication table for {number}:");

            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine($"{number} x {index} = {number * index}");
            }

            Console.WriteLine();

            /*Task 2: Sum of First N Numbers Using a While Loop
            Description: Ask the user to enter a positive integer N and calculate the sum of the first N natural numbers.

            Explanation:

            Use a while loop to add each number from 1 to N to a running total.
            Sample Input and Output:

            Enter a positive integer: 5
            Output: The sum of the first 5 numbers is 15*/

            Console.WriteLine("Enter a positive integer");

            int N;

            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            int sum = 0;
            int i = 0;

            while (i < N)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"The sum of the first {N} natural numbers is: {sum}");

            Console.WriteLine();

            /*Task 3: Find Factorial of a Number Using a For Loop
            Description: Write a program that calculates the factorial of a number entered by the user.

            Explanation:

            Factorial of N (written as N!) is calculated as N * (N - 1) * ... * 1.
            Use a for loop to multiply each number from 1 to N.
            Sample Input and Output:

            Enter a positive integer: 4
            Output: The factorial of 4 is 24*/



            int number1;

            while (true)
            {
                Console.WriteLine("Enter a number");
                bool isValidParsing = int.TryParse(Console.ReadLine(), out number1);
                if (isValidParsing == false)
                {
                    Console.WriteLine("Enter a valid number");
                    break;
                }
                Console.WriteLine("Enter a  number");
            }


            double factorial = 1;

            for (int index = 0; index <= number1; index++)
            {
                factorial *= index;
            }
            Console.WriteLine($"Factorial of {number1} is {factorial}");



            Console.WriteLine();

            /*Task 4: Count Down from N to 1 Using a Do-While Loop
            Description: Prompt the user to enter a positive integer N, then print all numbers from N down to 1.

            Explanation:

            Use a do-while loop that starts at N and decreases by 1 in each iteration until it reaches 1.
            Sample Input and Output:

            Enter a positive integer: 5
            Output:
            5
            4
            3
            2
            1*/



            int N1;

            do
            {
                Console.Write("Enter a positive integer N: ");
            }
            while (!int.TryParse(Console.ReadLine(), out N1) || N1 <= 0);

            Console.WriteLine($"Counting down from {N1} to 1:");

            do
            {
                Console.WriteLine(N1);

                N1--;

            } while (N1 > 0);

            Console.WriteLine();

            /*Task 5: Count Occurrences of a Character Using Foreach Loop with Continue
            Description: Ask the user to enter a string and a character, then count how many times the character appears in the string.

            Explanation:

            Use a foreach loop to iterate through each character in the string.
            Use continue to skip characters that don’t match the specified character.
            Sample Input and Output:

            Enter a string: Mississippi
            Enter a character to count: s
            Output: The character 's' appears 4 times.*/


            Console.Write("Enter a string:");

            string inputString = Console.ReadLine();

            Console.Write("Enter a character to count:");

            char characterToCount;

            while (!char.TryParse(Console.ReadLine(), out characterToCount))
            {
                Console.Write("Please enter a single character");

                Console.Write("Enter a character to count");
            }

            int count = 0;

            foreach (char c in inputString)
            {
                if (c != characterToCount)
                {
                    continue;
                }
                count++;
            }

            Console.WriteLine($"The character '{characterToCount}' appears {count} times in the string.");

            Console.WriteLine();


            /*Task 6: Calculate the Average of N Numbers Using For Loop with Break
            Description: Write a program that asks the user for a number N and then asks them to input N numbers, calculating the average of these numbers. Stop input if the user enters 0.

            Explanation:

            Use a for loop to accumulate a sum of N numbers.
            Use break to stop if the user enters 0 before reaching N.
            Sample Input and Output:

            Enter the number of values: 3
            Enter number 1: 5
            Enter number 2: 0
            Output: Input stopped early. The average is 5*/


            Console.Write("Enter the number of values to input (N): ");

            if (!int.TryParse(Console.ReadLine(), out int N2) || N2 <= 0)
            {
                Console.WriteLine("Please enter valid positive integer for N. ");
                return;
            }

            int count1 = 0;
            double sum1 = 0;

            for (int index = 0; index < N2; index++)
            {

                Console.Write($"Enter number {index + 1}: ");

                if (!double.TryParse(Console.ReadLine(), out sum1))
                {
                    Console.WriteLine("Invalid number . Please enter a number");
                    index--;
                    continue;
                }
                if (N2 == 0)
                {
                    Console.WriteLine("Input stopped by entering 0.");
                    break;
                }

                sum1 += N2;
                count1++;
                if (count1 > 0)
                {
                    double average = sum1 / count1;
                    Console.WriteLine($"The average of the entered numbers  is: {average}");
                }
                else
                {
                    Console.WriteLine("No valid numbers were entered to calculate an average.");
                }
            }

            Console.WriteLine();

            /*Task 7: Find the Largest Number Using a For Loop
            Description: Prompt the user to enter a number N for how many numbers they’d like to input. Then ask for each number and determine the largest among them.

            Explanation:

            Use a for loop to compare each entered number to the current largest number.
            Sample Input and Output:

            How many numbers will you enter? 4
            Enter number 1: 5
            Enter number 2: 10
            Enter number 3: 3
            Enter number 4: 8
            Output: The largest number is 10*/

            int number2;

            while (true)
            {
                Console.WriteLine("How many numbers will you enter?");
                bool isValidParsing = int.TryParse(Console.ReadLine(), out number2);

                if (isValidParsing == true)
                {

                    break;

                }
                Console.WriteLine("Enter a  valid number");
            }

            int largestNumber = 0;

            for (int index = 1; index <= number2; index++)
            {
                int currentNumber2;

                while (true)
                {
                    Console.Write("Enter number: ");
                    bool isValidParsing = int.TryParse(Console.ReadLine(), out currentNumber2);

                    if (isValidParsing == true)
                    {

                        break;

                    }
                    Console.WriteLine("Enter a  valid number");
                }
                if (currentNumber2 > largestNumber)
                {
                    largestNumber = currentNumber2;
                }

            }
            Console.WriteLine("The largest number: " + largestNumber);

            Console.WriteLine();


            /*Task 8: Check if a Number is Prime Using a For Loop with Break
            Description: Write a program that prompts the user to enter a positive integer and checks if it’s a prime number.

            Explanation:

            A prime number has no divisors other than 1 and itself.
            Use a for loop to check if any number from 2 to N-1 divides N evenly.
            Use break if a divisor is found, indicating the number is not prime.
            Sample Input and Output:

            Enter a positive integer: 7
            Output: 7 is a prime number.

            Enter a positive integer: 9
            Output: 9 is not a prime number.*/

            int number4;

            while (true)
            {
                Console.Write("Enter a positive integer");
                bool isValidParsing = int.TryParse(Console.ReadLine(), out number4);
                if (isValidParsing == false)
                {
                    Console.WriteLine("Enter a valid number");
                    break;
                }
                Console.WriteLine("Enter a positive integer");
            }

            int primeNumber = 0;

            for (int index = 2; index <= Math.Sqrt(number4); index++)
            {
                int currentNumber4;
                while (true)
                {
                    Console.Write("Enter number");
                    bool isValidParsing = int.TryParse(Console.ReadLine(), out currentNumber4);

                    if (isValidParsing == true)
                    {
                        break;
                    }
                    Console.WriteLine("Enter a valid number");
                }
                if (number4 % index == 0)
                {
                    primeNumber++;
                }
            }
            Console.WriteLine($"The number is: {primeNumber}");




            /*Task 9: Print Multiples of a Number Up to N Using While Loop with Continue
            Description: Write a program that asks for two numbers: a base number and a limit N. Print all multiples of the base number up to N.

            Explanation:

            Use a while loop to print multiples of the base number up to N.
            Use continue if the current number is not a multiple of the base number.
            Sample Input and Output:

            Enter the base number: 3
            Enter the limit: 20
            Output:
            3
            6
            9
            12
            15
            18*/


            Console.Write("Enter the base number:");

            if (!int.TryParse(Console.ReadLine(), out int baseNumber5) || baseNumber5 <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the base number.");
                return;
            }

            Console.Write("Enter the limit (N):");

            if (!int.TryParse(Console.ReadLine(), out int limit) || limit <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the limit.");
                return;
            }

            Console.WriteLine($"Multiples of {baseNumber5} up to {limit}:");

            int multiple = baseNumber5;

            while (multiple <= limit)
            {
                Console.WriteLine(multiple);
                multiple += baseNumber5;
                continue;
            }

            Console.WriteLine();

            /*Task 10: Reverse a String Using a For Loop
            Description: Ask the user to enter a string and display it in reverse order.

            Explanation:

            Use a for loop to iterate through the string from the end to the beginning, constructing the reversed version.
            Sample Input and Output:

            Enter a string: Hello
            Output: Reversed string: olleH*/

            string input4 = "";


            while (true)
            {
                Console.WriteLine("Enter a string");
                bool isStringParsing = int.TryParse(Console.ReadLine(), 

                if (isStringParsing == false)
                {
                    Console.WriteLine("Enter a valid string");
                    break;
                }
                Console.WriteLine("Enter a string");

            }

            string reversed = "";


            for (int index = input4.Length - 1; index >= 0; index--)
            {
                reversed += input4[index];
            }
            Console.WriteLine("Reversed string: " + reversed);

            Console.WriteLine();

            /*Task 11: Find the First Multiple of 7 Using a For Loop with Break
            Description: Write a program that prompts the user to enter a positive integer N. Then, use a loop to find the first multiple of 7 between 1 and N. If a multiple is found, stop the loop.

            Explanation:

            Use a for loop to iterate from 1 to N.
            Check if each number is divisible by 7 (number % 7 == 0). If true, display the number and use break to exit the loop.
            Sample Input and Output:

            Enter a positive integer: 20
            Output: The first multiple of 7 between 1 and 20 is 7
            Example:

            Enter a positive integer: 5
            Output: There is no multiple of 7 between 1 and 5*/

            int input5;

            while (true)
            {
                Console.Write("Enter a positive integer N:");
                bool isValidParsing = int.TryParse(Console.ReadLine(), out input5);

                if (isValidParsing == false)
                {
                    Console.WriteLine("Enter a valid number");
                    break;
                }
                Console.WriteLine("Enter a positive integer N:");
            }
                
            bool found = true;

            if (!int.TryParse(input4, out int N3) && N3 > 0)
            {
                

                for (int index = 1; index < N3; index++)
                {
                    if (index % 7 == 0)
                    {
                        Console.WriteLine("The first multiple of 7 between 1 and " + N3 + "is: " + 1);
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    Console.WriteLine("No multiple of 7 between 1 and " + N3);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Plesase enter a positive integer.");
            }

            Console.WriteLine();

            /*Task 12: Print Odd Numbers Using a For Loop with Continue
            Description: Write a program that prompts the user to enter a positive integer N and then prints all odd numbers from 1 to N.

            Explanation:

            Use a for loop to iterate from 1 to N.
            Use continue to skip even numbers and only print odd numbers.
            Sample Input and Output:

            Enter a positive integer: 10
            Output:
            1
            3
            5
            7
            9
            */

            int N4 = 0;
            while (true)
            {
                Console.WriteLine("Enter a positive integer N:");
                bool isValidParsing = int.TryParse(Console.ReadLine(), out N4);




                if (int.TryParse(Console.ReadLine(), out N4) && N4 > 0)
                {
                    Console.WriteLine($"Odd numbers from 1 to {N4}:");

                    for (int index = 1; index <= N4; index++)
                    {
                        if (index % 2 == 0)
                        {
                            continue;
                        }
                        Console.WriteLine(index);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }





















        }
    }
}
