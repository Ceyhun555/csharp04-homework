using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal static class MethodTasks
    {
        //Task 1:
        public static void Greet()
        {
            Console.WriteLine("Hello, welcome to C# programming!");
        }

        //Task 2:

        public static void PersonalizedGreet(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to C# programmming.");
        }

        //Task 3:
        public static int CalculateSquare(int number) => number * number;

        //Task 4:
        public static int Add(int a, int b) => a + b;
        public static int Add(int a, int b, int c) => a + b + c;


        //Task 5:
        public static void ModifyValue(int value)
        {
            value *= 2;
            Console.WriteLine($"Modified value inside method: {value}");
        }

        //Task 6:
        public static void ModifyValue(ref int value)
        {
            value *= 2;
            Console.WriteLine($"Value inside method: {value}");
        }

        //Task 7:
        public static void CalculateQuotientAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        //Task 8:
        public static int CalculateArea(int length, int width = 0) => width == 0 ? length * length : length * width;

        //Task 9:
        public static int CalculateFactorial(int number) => number == 0 ? 1 : number * CalculateFactorial(number - 1);

        //Task 10:
        public static int FindLargest(int[] array)
        {
            int max = int.MinValue;
            foreach (var item in array)
            {
                if (item > max) max = item;
            }
            return max;
        }

        //Task 11:
        

        public static double Calculate()
        {

        }




    }
}
