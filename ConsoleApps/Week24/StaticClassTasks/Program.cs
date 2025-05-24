using StaticClass.Tasks;
using System.Runtime.CompilerServices;

namespace StaticClassTasks
{
    internal class Program
    {
        public static void Main()
        {
            //Task 1:
            Console.WriteLine(MathUtilities.Square(4));
            Console.WriteLine(MathUtilities.Cube(3));
            Console.WriteLine(MathUtilities.Factorial(5));
            Console.WriteLine();




            //Task 2:
            Logger.EnableLogging = true;
            Logger.Log("Application started");
            Logger.Error("Null reference exception occurred");
            Console.WriteLine();




            //Task 3:
            Console.WriteLine(ConfigManager.ApplicationName);
            Console.WriteLine(ConfigManager.Version);

            ConfigManager.Reload();
            Console.WriteLine();



            //Task 4:
            Console.WriteLine("racecar".IsPalindrome());     
            Console.WriteLine("hello world".ToTitleCase()); 
            Console.WriteLine();


            //Task 5:
            Console.WriteLine(DateTimeHelper.GetCurrentDate()); 

            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2025, 12, 31);
            Console.WriteLine(DateTimeHelper.DaysBetween(start, end));
        }
    }
    

}
