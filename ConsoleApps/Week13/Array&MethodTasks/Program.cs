using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System;

namespace Array_MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task 1: Filter Even Numbers from an Array
            Task Description
            Create an array of 8 random integers between 1 and 50.
            Write a method FilterEvenNumbers(int[] numbers) that filters and returns only the even numbers from the array.
            Print the filtered even numbers.
            Explanation
                        Use a loop to generate random numbers between 1 and 50.
            The method FilterEvenNumbers iterates through the array, checks if each number is even using the modulus operator %, and adds it to a new list if true.
            Finally, the filtered list of even numbers is printed.
            Sample Input & Output
            Input Array:
            { 23, 12, 45, 36, 19, 8, 50, 17}
                    Output:
                        Even Numbers: 12, 36, 8, 50 */ 


            Console.WriteLine("Task 1: Filter Even Numbers");
            int[] randomNumbers = GenerateRandomNumbers(8, 1, 50);
            Console.WriteLine("Input Array: " + string.Join(", ", randomNumbers));
            var evenNumbers = FilterEvenNumbers(randomNumbers);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
            


            /*Task 2: Sort Fruit Names Alphabetically
            Task Description
            Create an array of 5 fruit names.
            Write a method SortFruits(string[] fruits) that sorts the array alphabetically and prints each fruit on a new line.
            Explanation
            The method uses Array.Sort() to sort the fruit names alphabetically.
            After sorting, each fruit is printed using a loop.
            Sample Input & Output
            Input Array:
            {"Banana", "Apple", "Grape", "Mango", "Peach"}
            Output:

            Apple  
            Banana  
            Grape  
            Mango  
            Peach  */


            Console.WriteLine("\nTask 2: Sort Fruit Names");
            string[] fruits = { "Banana", "Apple", "Grape", "Mango", "Peach" };
            Console.WriteLine("Input Array: " + string.Join (", ", fruits));
            SortFruits(fruits);



            /* Task 3: Print a Tic-Tac-Toe Board
            Task Description
            Create a 3x3 char array representing a tic-tac-toe board with values 'X', 'O', and ' '.
            Write a method PrintBoard(char[,] board) to display the board in a grid format.
            Explanation
            Initialize a 2D char array with tic-tac-toe values.
            The PrintBoard method uses nested loops to print the array in grid format, ensuring separators like | and newlines are properly formatted.
            Sample Input & Output
            Input:

            X | O | X  
            O | X |   
              | O | X  */


            Console.WriteLine("\nTask 3: Tic-Tac-Toe Board");
            char[,] board = {
            { 'X', 'O', 'X' },
            { 'O', 'X', ' ' },
            { ' ', 'O', 'X' }
        };
            PrintBoard(board);



            /* Task 4: Calculate Rectangle Area with Default Width
            Task Description
            Write a method CalculateRectangleArea(int length, int width = 5) that calculates and returns the area.
            Call it twice: once with both parameters and once with only the length.
            Explanation
            If the user does not provide a width, the method uses the default value of 5.
            Display the calculated area in both cases.
            Sample Input & Output
            Input:

            CalculateRectangleArea(10)  
            CalculateRectangleArea(8, 6)  
            Output:

            Area with default width: 50  
            Area with provided width: 48  */


            Console.WriteLine("\nTask 4: Calculate Rectangle Area");
            Console.WriteLine("CalculateRectangleArea(10)");
            Console.WriteLine("CalculateRectangleArea(8, 6)");
            Console.WriteLine("Area with default width: " + CalculateRectangleArea(10));
            Console.WriteLine("Area with provided width: " + CalculateRectangleArea(8, 6));



            /* Task 5: Calculate Sum and Average of an Array
            Task Description
            Write a method CalculateSumAndAverage(int[] numbers) that returns both the sum and average of an integer array.
            Create an array {10, 20, 30, 40, 50} and call the method to display the results.
            Explanation
            The method calculates the sum using a loop and divides it by the array length for the average.
            Return and print both values.
            Sample Input & Output
            Input:
            {10, 20, 30, 40, 50}
            Output:

            Sum: 150  
            Average: 30  */


            Console.WriteLine("\nTask 5: Sum and Average");
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Input: " + string.Join(",", numbers));
            var (sum, average) = CalculateSumAndAverage(numbers);
            Console.WriteLine($"Sum: {sum}, Average: {average}");




            /* Task 6: Find the Largest Number
            Task Description
            Create a method FindMax(int num1, int num2) that returns the larger of the two numbers.
            Use this method to find and display the largest number in {34, 78, 12, 89, 23}.
            Explanation
            Use the FindMax method in a loop to compare each pair and find the maximum number.
            Print the final maximum.
            Sample Input & Output
            Input:
            {34, 78, 12, 89, 23}
            Output:
            Largest Number: 89 */


            Console.WriteLine("\nTask 6: Largest Number");
            int[] numArray = { 34, 78, 12, 89, 23 };
            Console.WriteLine("Input: " + string.Join(",", numArray));
            int largest = FindMax(numArray);
            Console.WriteLine("Largest Number: " + largest);




            /* Task 7: Method Overloading - Display Different Types
            Task Description
            Write a method Display that prints different messages based on the parameter type:
            int → "Number: [value]"
            string → "Message: [value]"
            double → "Decimal Value: [value]"
            Explanation
            Method overloading allows different methods with the same name to handle different types.
            Test by calling Display with various types.
            Sample Input & Output
            Input:

            Display(5)  
            Display("Hello")  
            Display(4.75)  
            Output:

            Number: 5  
            Message: Hello  
            Decimal Value: 4.75  */


            Console.WriteLine("\nTask 7: Method Overloading");
            Console.WriteLine("Display(5)");
            Console.WriteLine("Display(\" Hello \")");
            Console.WriteLine("Display(4.75");
            Display(5);
            Display("Hello");
            Display(4.75);



            /*Task 8: Box Volume Calculator with Named Arguments
            Task Description
            Write a method CalculateVolume(int length, int width, int height) that returns the volume of a box.
            Call the method using named arguments.
            Explanation
            Named arguments enhance readability, allowing parameter names in the method call.
            Display the calculated volume.
            Sample Input & Output
            Input:

            CalculateVolume(width: 4, height: 5, length: 6)  
            Output:

            Volume: 120  */


            Console.WriteLine("\nTask 8: Box Volume Calculator");
            int volume = CalculateVolume(length: 6, width: 4, height: 5);
            Console.WriteLine("Input: " + string.Join (",", volume));
            Console.WriteLine("Volume: " + volume);




            /*Task 9: Swap Two Numbers Using ref and out Parameters
            Task Description
            Write a method SwapNumbers that swaps two numbers using ref and calculates their sum using out.
            The method should take two integers as ref parameters and return their sum as an out parameter.
            Call the method with two numbers, display the swapped values, and print their sum.
            Explanation
            The ref keyword allows passing arguments by reference, enabling the method to modify the caller’s variables directly.
            The out keyword is used to return multiple values from a method. In this case, it returns the sum of the swapped numbers.
            Sample Input & Output
            Input:

            a = 10, b = 20
            Output:

            Before Swap: a = 10, b = 20  
            After Swap: a = 20, b = 10  
            Sum: 30  */


            Console.WriteLine("\nTask 9: Swap Two Numbers");
            int a = 10, b = 20;
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            SwapNumbers(ref a, ref b, out int sumSwap);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");
            Console.WriteLine($"Sum: {sumSwap}");
        }

        private static object?[] FilterEvenNumbers(int[] randomNumbers)
        {
            throw new NotImplementedException();
        }



        // Task 1
        static int[] GenerateRandomNumbers(int count, int min, int max)
        {
            Random random = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(min, max + 1);
            }
            return numbers;
        }

        

        // Task 2
        static void SortFruits(string[] fruits)
        {
            Array.Sort(fruits);
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }

        // Task 3
        static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                    if (j < board.GetLength(1) - 1) Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        // Task 4
        static int CalculateRectangleArea(int length, int width = 5)
        {
            return length * width;
        }

        // Task 5
        static (int sum, double average) CalculateSumAndAverage(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            double average = (double)sum / numbers.Length;
            return (sum, average);
        }

        // Task 6
        static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (var number in numbers)
            {
                max = Math.Max(max, number);
            }
            return max;
        }

        // Task 7
        static void Display(int value)
        {
            Console.WriteLine("Number: " + value);
        }
        static void Display(string value)
        {
            Console.WriteLine("Message: " + value);
        }
        static void Display(double value)
        {
            Console.WriteLine("Decimal Value: " + value);
        }

        // Task 8
        static int CalculateVolume(int length, int width, int height)
        {
            return length * width * height;
        }

        // Task 9
        static void SwapNumbers(ref int a, ref int b, out int sum)
        {
            int temp = a;
            a = b;
            b = temp;
            sum = a + b;
        }
    }
}

