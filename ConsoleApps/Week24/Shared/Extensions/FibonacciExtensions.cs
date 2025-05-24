using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Extensions
{
    public static class IntExtensions
    {
        public static long NthFibonacci(this int n)
        {
            if (n < 0)
                throw new ArgumentException("N cannot be negative.");

            if (n == 0) return 0;
            if (n == 1) return 1;

            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
