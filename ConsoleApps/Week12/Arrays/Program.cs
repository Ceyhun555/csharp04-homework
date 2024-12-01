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

            int[] array = { 1, 2, 3, 4, 5, };

            Console.WriteLine("Original array: " + string.Join(", ", array));
            Console.Write("Enter index to modify (0-4): ");

            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < array.Length)
            {
                Console.Write("Enter new value: ");
                if (int.TryParse(Console.ReadLine(), out int newValue))
                {
                    array[index] = newValue;
                    Console.WriteLine("Modified array: " + string.Join(",", array));
                }
                else
                {
                    Console.WriteLine("Invalid value.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
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

            int[] array1 = { 5, 10, 15, 20, 25 };
            Console.WriteLine("Array: " + string.Join(", ", array1));

            Console.WriteLine("Array elements: ");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();


            /*Task 4: Array Length and Iterating Using a foreach Loop
            Description
            Write a program to find the length of an array and iterate through its elements using a foreach loop.

            Explanation
            The Length property gives the total number of elements in the array.
            The foreach loop simplifies iterating over all elements without using indexes.
            Sample Input and Output
            Input:

            Array: [2, 4, 6, 8]
            Output:

            Array length: 4
            Array elements:
            2
            4
            6
            8  */

            int[] array2 = { 2, 4, 6, 8, };

            Console.WriteLine("Array: " + string.Join(",", array2));
            Console.WriteLine("Array length: " + array2.Length);

            Console.WriteLine("Array elements:");

            foreach (int element in array2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();


            /*Task 5: Finding the Maximum and Minimum Values in an Array
            Description
            Write a program to find the largest and smallest numbers in an integer array.

            Explanation
            You can traverse the array to compare each element and keep track of the largest and smallest values.

            Sample Input and Output
            Input:

            Array: [10, 20, 5, 8, 30]
            Output:

            Maximum value: 30
            Minimum value: 5  */

            int[] array3 = { 10, 20, 5, 8, 30 };
            Console.WriteLine("Array: " + string.Join(",", array3));

            int max = array3[0];
            int min = array3[0];

            foreach (int num in array3)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minumum value: {min}");
            Console.WriteLine();

            /*Task 6: Summing All Elements in an Array
            Description
            Write a program to calculate the sum of all elements in an array.

            Explanation
            Iterate through the array and keep adding each element to a running total.

            Sample Input and Output
            Input:

            Array: [1, 2, 3, 4, 5]
            Output:

            Sum of elements: 15 */

            int[] array4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array: " + string.Join(",", array4));

            int sum = 0;

            foreach (int num in array4)
            {
                sum += num;
            }

            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine();


            /*Task 7: Reversing an Array
            Description
            Write a program to reverse the elements of an array.

            Explanation
            Traverse the array from the last element to the first and print them in reverse order.

            Sample Input and Output
            Input:

            Array: [1, 2, 3, 4, 5]
            Output:

            Reversed array: [5, 4, 3, 2, 1]  */

            int[] array5 = { 1, 2, 3, 4, 5, };

            Console.WriteLine("Array: " + string.Join(",", array5));

            int[] reversedArray = new int[array5.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = array5[array5.Length - 1 - i];
            }
            Console.WriteLine("Reversed array: [" + string.Join(",", reversedArray) + "]");
            Console.WriteLine();

            /*Task 8: Sorting an Array
            Description
            Write a program to sort an array in ascending order.

            Explanation
            Use Array.Sort() to sort the array elements automatically.

            Sample Input and Output
            Input:

            Array: [10, 5, 20, 15]
            Output:

            Sorted array: [5, 10, 15, 20]  */

            int[] array6 = { 10, 5, 20, 15 };

            Console.WriteLine("Array: " + string.Join(",", array6));

            Array.Sort(array6);

            Console.WriteLine("Sorted array: [" + string.Join(',', array6) + "]");

            Console.WriteLine();


            /*Task 9: Basic 2D Array Operations
            Description
            Write a program to create a 2D array and display its elements.

            Explanation
            A 2D array stores data in rows and columns. You can use nested loops to traverse it.

            Sample Input and Output
            Input:

            2D Array:
            [1, 2]
            [3, 4]
            Output:

            2D Array elements:
            1 2
            3 4  */

            int[,] array7 = {
                { 1, 2 },
                { 3, 4 }
            };

            Console.WriteLine("2D Array elements:");
            for (int i = 0; i < array7.GetLength(0); i++)
            {
                for (int j = 0; j < array7.GetLength(1); j++)
                {
                    Console.Write(array7[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*Task 10: Real-World Scenario - Finding Duplicate Elements
            Description
            Write a program to find and print duplicate elements in an array.

            Explanation
            Compare each element with the rest of the array to identify duplicates.

            Sample Input and Output
            Input:

            Array: [1, 2, 3, 2, 4, 5, 1]
            Output:

            Duplicate elements: 1, 2  */

            int[] array8 = { 1, 2, 3, 2, 4, 5, 1 };
            bool[] isDuplicate = new bool[array8.Length];

            Console.WriteLine("Duplicate elements: ");
             for (int i = 0; i < isDuplicate.Length; i++)
            {
                if (isDuplicate[i]) continue;

                for (int j = 0;j < array8.Length; j++)
                {
                    if (array8[i] == array8[j])
                    {
                        Console.WriteLine(array8[i]);
                        isDuplicate[j] = true;
                        break;
                    }
                }
            }




            /*Task 11: Finding the Index of an Element
            Description
            Write a program to find the index of a specific element in an array.

            Explanation
            Iterate through the array and compare each element with the target value to find its index.

            Sample Input and Output
            Input:

            Array: [10, 20, 30, 40]
            Element to find: 30
            Output:

            Element found at index: 2  */


            int[] array9 = { 10, 20, 30, 40 };

            Console.WriteLine("Array: " + string.Join(",", array9));
            int inputNumber;

            while (true)
            {
                Console.Write("Enter the element to find: ");
                bool isInputNumberParsing = int.TryParse(Console.ReadLine(), out inputNumber);

                if (isInputNumberParsing == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                else 
                {  
                    int index1 = -1; 
                    for (int i = 0; i < array9.Length; i++)
                    {
                        if (array9[i] == inputNumber)
                        {
                            index1 = i;
                            break; 
                        }
                    }
                    if (index1 != -1)
                    {
                        Console.WriteLine($"Element found at index: {index1}");
                    }
                    else
                    {
                        Console.WriteLine("Element not found in the array.");
                    }
                    break;
                }

            }





















            }
    }
}
