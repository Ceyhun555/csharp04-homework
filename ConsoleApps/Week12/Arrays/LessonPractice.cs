using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LessonPractice
    {
        //public void FindElementInArray()
        //{
        //    int[] array = { 10, 20, 30, 40, 50 };

        //    //Version 1
        //    int index = Array.IndexOf(array, 20);
        //    Console.WriteLine(array[index]);
        //    array[index] = 70;
        //    //Version 2


        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == 20)
        //        {
        //            Console.WriteLine(array[i]);
        //            break;
        //        }

        //    }

        //}


        /*Task 1: Filter Even Numbers from an Array
         * 
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
        {23, 12, 45, 36, 19, 8, 50, 17}
        Output:
        Even Numbers: 12, 36, 8, 50 */



        static void Main(string[] args)
        {
            int[] numbers = GenerateRandomNumbers(8, 1, 50);

            Console.WriteLine("Input Array:");
            Console.WriteLine("{" + string.Join(", ", numbers) + "}");
            int[] evenNumbers = FilterEvenNumbers(numbers);
            Console.WriteLine("Even Numbers:");
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
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
        static int[] FilterEvenNumbers(int[] numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers.ToArray();
        }



        /*Task 2: Sort Fruit Names Alphabetically
         * 
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
        Peach    */


        static void Main1(string[] args)
        {
            string[] fruits = { "Banana", "Appale", "Grape", "Mango", "Peach" };
            Console.WriteLine("Input Array: ");
            Console.WriteLine("(" + string.Join(", ", fruits) + ")");
            SortFruits(fruits);
        }

        static void SortFruits(string[] fruits)
        {
            Array.Sort(fruits);
            Console.WriteLine("\nSorted Fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }

        /*Task 3: Print a Tic-Tac-Toe Board
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
          | O | X    */


        static void Main2(string[] args)
        {
            char[,] board =
            {
                {'X', 'O', 'X' },
                {'O', 'X', ' ' },
                {' ', 'O', 'X' }
            };

            Console.WriteLine("Tic-Tac-Toe Board: ");
            PrintBoard(board);
        }

        static void PrintBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Console.WriteLine(board[row, col]);
                    if (col < board.GetLength(1) - 1)
                    {
                        Console.WriteLine(" | ");
                    }
                }
                Console.WriteLine();

                if (row < board.GetLength(0) - 1)
                {
                    Console.WriteLine("--+---+--");


                }
            }

        }

        /*Task 4: Calculate Rectangle Area with Default Width
         * 
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
        Area with provided width: 48   */
        static void Main3(string[] args)
        {
            int areaWithDefaultWidth = CalculateRectangleArea(10);
            int areaWithProvidedWidth = CalculateRectangleArea(8, 6);
            Console.WriteLine($"Area with default width: {areaWithDefaultWidth}");
            Console.WriteLine($"Area with provided witdth: {areaWithProvidedWidth}");
        }
        static int CalculateRectangleArea(int length, int width = 5)
        {
            return length * width;
        }


        /*Task 5: Calculate Sum and Average of an Array
         * 
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
        
        static void Main4(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            (int sum, double average) = CalculateSumAndAverage(numbers);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }

        static (int sum, double average) CalculateSumAndAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;
            return (sum, average);
        }


        /*Task 6: Find the Largest Number
         * 
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
        Largest Number: 89  */


        static void Main5(string[] args)
        {
            int[] numbers2 = { 34, 78, 12, 89, 23 };
            int largest = FindLargestNumber( numbers2 );
            Console.WriteLine($"Largest number: {largest}");
        }

        static int  FindLargestNumber (int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers )
            {
                max = FindMax(max , number);
            }
            return max;
        }

        static int FindMax(int num1, int num2)
        {
            return (num1> num2) ? num1 : num2;
        }




        /*Task 7: Method Overloading - Display Different Types
         * 
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


        static void Main6(string[] args)
        {
            Display(5);
            Display("Hello");
            Display(4.75);               
        }

        static void Display(int value)
        {
            Console.WriteLine($"Number: {value}");
        }

        static void Display(string value)
        {
            Console.WriteLine($"Message: {value}");
        }

        static void Display(double value)
        {
            Console.WriteLine($"Decimal value: {value}");
        }


        /*Task Description
        Write a method CalculateVolume(int length, int width, int height) that returns the volume of a box.
        Call the method using named arguments.
        Explanation
        Named arguments enhance readability, allowing parameter names in the method call.
        Display the calculated volume.
        Sample Input & Output
        Input:

        CalculateVolume(width: 4, height: 5, length: 6)  
        Output:

        Volume: 120 */


        static void Main7(string[] args)
        {
            int volume = CalculateVolume(width: 4, height: 5, length: 6);
            Console.WriteLine($"Volume: {volume}");
        }


        static int CalculateVolume(int width, int height, int length)
        {
            return length * width * height;
        }



        /*Task 9: Swap Two Numbers Using ref and out Parameters
         * 
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
            
        static void Main8(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swap: a = {a},  b= {b}");
            SwapNumbers(ref a, ref b, out int sum);
            Console.WriteLine($"After swap: a = {a }, b = {b}");
            Console.WriteLine($"Sum: {sum}");   
        }

        static void SwapNumbers(ref int num1,  ref int num2, out int sum)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            sum = num1 + num2;
        }


    }
}



