using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Boxing.Unboxing
{
    internal class BoxingPerformance
    {
        static void Main()
        {

            const int size = 1000000;


            object[] boxedArray = new object[size];

            int[] intArray = new int[size];

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < size; i++)
            {
                boxedArray[i] = i;
            }
            stopwatch.Stop();
            Console.WriteLine($"Time for boxing: {stopwatch.ElapsedMilliseconds} ms");


            stopwatch.Restart();

            for(int i = 0; i < size; i++)
            {
                int value = (int)boxedArray[i];
            }
            stopwatch.Stop();

            Console.WriteLine($"Time for unboxing: {stopwatch.ElapsedMilliseconds} ms");


            stopwatch.Restart();

            for(int i = 0; i < size; i++)
            {
                intArray[i] = i;
            } 
            stopwatch.Stop();

            Console.WriteLine($"Time for direct type usage: {stopwatch.ElapsedMilliseconds} ms");






        }

    }
}
