using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /// <summary>
    /// Week 12 ArrayTasks
    /// </summary>
    internal class ArrayTasks
    {
        /// <summary>
        /// Task 1: Declaring and Initializing Arrays
        /// Description
        ///Write a program to declare and initialize an integer array with five elements and print them.
        ///Explanation
        ///Arrays in C# are used to store multiple values of the same data type. 
        ///This task introduces how to declare an array, assign values, and display them.
        /// Sample Input and Output
        /// No input required.
        /// Output:
        ///Array elements: 1, 2, 3, 4, 5 */
        /// </summary>
        public static void DeclareAndPrint()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.Write("Array elements: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }



        public static void ModifyArray(int[] array)
        {
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
        }




        public static void IterateOverAnArray()
        {
            int[] array1 = { 5, 10, 15, 20, 25 };
            Console.WriteLine("Array: " + string.Join(", ", array1));

            Console.WriteLine("Array elements: ");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
        }




        public static void LengthOfAnArray()
        {
            int[] array2 = { 2, 4, 6, 8, };

            Console.WriteLine("Array: " + string.Join(",", array2));
            Console.WriteLine("Array length: " + array2.Length);

            Console.WriteLine("Array elements:");

            foreach (int element in array2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }



        public static void FindMaxAndMin()
        {
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
        }




        public static void  CalculateTheSum()
        {
            int[] array4 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array: " + string.Join(",", array4));

            int sum = 0;

            foreach (int num in array4)
            {
                sum += num;
            }

            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine();
        }

        public static void ReverseAnArray()
        {
            int[] array5 = { 1, 2, 3, 4, 5, };

            Console.WriteLine("Array: " + string.Join(",", array5));

            int[] reversedArray = new int[array5.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = array5[array5.Length - 1 - i];
            }
            Console.WriteLine("Reversed array: [" + string.Join(",", reversedArray) + "]");
            Console.WriteLine();

        }


        public static void SortAnArray()
        {
            int[] array6 = { 10, 5, 20, 15 };

            Console.WriteLine("Array: " + string.Join(",", array6));

            Array.Sort(array6);

            Console.WriteLine("Sorted array: [" + string.Join(',', array6) + "]");

            Console.WriteLine();
        }


        public static void Create2DArray()
        {
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
        }

        public static void FindingDuplicateArray()
        {
            int[] array8 = { 1, 2, 3, 2, 4, 5, 1 };
            bool[] isDuplicate = new bool[array8.Length];

            Console.WriteLine("Duplicate elements: ");
            for (int i = 0; i < isDuplicate.Length; i++)
            {
                if (isDuplicate[i]) continue;

                for (int j = 0; j < array8.Length; j++)
                {
                    if (array8[i] == array8[j])
                    {
                        Console.WriteLine(array8[i]);
                        isDuplicate[j] = true;
                        break;
                    }
                }
            }
            Console.WriteLine();

        }


        public static void FindIndexOfAnArray()
        {
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
