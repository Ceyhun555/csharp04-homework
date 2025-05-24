using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentUserProfile
{
    public static class MathUtilities
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int Square(int number)
        {
            return number * number;
        }

        public static int Cube(int number)
        {
            return number * number * number;
        }

        public static long Factorial(int number)
        {
            if (number < 0)
                return -1; // Factorial for negative numbers is undefined.

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int NthFibonacci(int n)
        {
            if (n <= 0)
                return -1; // Fibonacci sequence starts from 1

            int a = 0, b = 1, next;
            for (int i = 2; i <= n; i++)
            {
                next = a + b;
                a = b;
                b = next;
            }
            return b;
        }
    }
}
