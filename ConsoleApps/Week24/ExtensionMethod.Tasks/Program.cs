using Shared;
using Shared.Extensions;

namespace ExtensionMethod.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Taks 1:
            //int number1 = 4;
            //int number2 = 7;

            //Console.WriteLine($"{number1} is even: {number1.IsEven()}");
            //Console.WriteLine($"{number2} is even: {number2.IsEven()}");
            //Console.WriteLine();



            ////Task 2:
            //DateTime birthDate = new DateTime(2001, 8, 26);
            //int age = birthDate.GetAge();
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine();

            ////Taks 3:
            //string sentence = " Hello,   world! Welcome to   C# programming. ";
            //Console.WriteLine(sentence.WordCount());
            //Console.WriteLine();


            ////Task 4:
            //int n = 10;
            //Console.WriteLine($"The {n}th Fibonacci number is {n.NthFibonacci()}");
            //Console.WriteLine();





            //// World Count  without split method
            //string text = " Hello,  world! This is a   test... ";
            //int wordCount = text.WordCount1();
            //Console.WriteLine($"Word count: {wordCount}");





            string sentence = " Hello,   world! Welcome to   C# programming. ";
            Console.WriteLine(sentence.WordCount());
            Console.WriteLine();



            string sentence1 = " Hello,   world! Welcome to   C# programming. ";
            Console.WriteLine(sentence1.WordCount1());
            Console.WriteLine();
        }
    }
}
