using System;
using System.ComponentModel.Design;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*Task 1: Declaring and Initializing Arrays
            Description
            Write a program to declare and initialize an integer array with five elements and print them.

            Explanation
            Arrays in C# are used to store multiple values of the same data type. This task introduces how to declare an array, assign values, and display them.

            Sample Input and Output
            No input required.
            Output:

            Array elements: 1, 2, 3, 4, 5 */

            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.Write("Array elements: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();


            /* Task 2: Accessing and Modifying Array Elements
            Description
            Write a program to access and modify elements of an integer array.

            Explanation
            Arrays allow individual elements to be accessed and modified using their index. Indexes start from 0.

            Sample Input and Output
            Input:

            Original array: [1, 2, 3, 4, 5]
            Enter index to modify (0-4): 2
            Enter new value: 10
            Output:

            Modified array: [1, 2, 10, 4, 5]  */

            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array: [" + string.Join(", ", array) + "]");


            int index = 0 - 4;

            while (true)
            {
                Console.Write("Enter index to modify (0-4): ");
                string inputIndex = Console.ReadLine();
                bool isinputIndexParsing = int.TryParse(inputIndex, out index);

                if (isinputIndexParsing == true && index >= 0 && index < array.Length)
                {
                    Console.Write("Enter new value: ");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please enter an index in the range 0-4.");
                }


                string inputValue = Console.ReadLine();
                bool isInputValueParsing = int.TryParse(inputValue, out int newValue);

                if (isInputValueParsing == true)
                {
                    array[index] = newValue;

                    Console.WriteLine("Modified array: [" + string.Join(",", array) + "]");
                }
                else
                {
                    Console.WriteLine("Invalid value. Please enter a valid value ");
                }
                break;
            }
            Console.WriteLine();


            /*Task 3: Iterating Over Arrays Using a for Loop
            Description
            Write a program to iterate over an array using a for loop and print all its elements.

            Explanation
            Using a for loop, you can iterate through the array by accessing each element using its index.

            Sample Input and Output
            Input:

            Array: [5, 10, 15, 20, 25]
            Output:

            Array elements:
            5
            10
            15
            20
            25  */


            string[] array1 = { "5", "10", "15", "20", "25" };

            Console.WriteLine("Array elements:");

            // Iterate over the array and use TryParse to validate and print each element
            for (int i = 0; i < array1.Length; i++)
            {
                if (int.TryParse(array1[i], out int number))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine($"Invalid element at index {i}: {array1[i]}");
                }
            }



















        }
    }
}
