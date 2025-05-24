using System.Text;

namespace IntelligentUserProfile
{
    public class UserProfileSystem
    {

        class Program
        {
            static IUserService _userService;
            static IMenuService _menuService;

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Welcome to the Intelligent Digital Assistant!\n");

                _userService = new UserService();
                User user = _userService.CreateProfile();

                _menuService = new MenuService(user, _userService);
                _menuService.Run();
            }
        }
    }
}







        //    public static void Main()
        //    {
        //        string birthdateInput;
        //        string bio;
        //        string favoriteNumberInput;

        //        DateTime birthdate;
        //        int favoriteNumber;
        //        int fibonacciN;

        //        Console.WriteLine("Welcome to the Intelligent Digital Assistant!");

        //        // Step 1: User Profile Setup
        //        Console.Write("Enter your birthdate (YYYY-MM-DD): ");
        //        birthdateInput = Console.ReadLine();
        //        while (!DateTime.TryParse(birthdateInput, out birthdate) || birthdate > DateTime.Now)
        //        {
        //            Console.WriteLine("Invalid date. Please enter a valid birthdate (YYYY-MM-DD): ");
        //            birthdateInput = Console.ReadLine();
        //        }

        //        int age = DateTime.Now.Year - birthdate.Year;
        //        if (birthdate > DateTime.Now.AddYears(-age)) age--; // Adjust if birthday hasn't occurred yet
        //        Console.WriteLine($"Your age: {age}");

        //        Console.Write("Enter a short bio about yourself: ");
        //        bio = Console.ReadLine();

        //        int wordCount = TextUtilities.WordCount(bio);
        //        Console.WriteLine($"Word count: {wordCount}");

        //        string titleCaseBio = TextUtilities.ToTitleCase(bio);
        //        Console.WriteLine($"Title Case: {titleCaseBio}");

        //        // Step 2: Perform Smart Number Analysis
        //        Console.Write("Enter your lucky number: ");
        //        favoriteNumberInput = Console.ReadLine();
        //        while (!int.TryParse(favoriteNumberInput, out favoriteNumber))
        //        {
        //            Console.WriteLine("Invalid number. Please enter a valid number: ");
        //            favoriteNumberInput = Console.ReadLine();
        //        }

        //        Console.WriteLine($"Is even? {MathUtilities.IsEven(favoriteNumber)}");
        //        Console.WriteLine($"Square: {MathUtilities.Square(favoriteNumber)}");
        //        Console.WriteLine($"Cube: {MathUtilities.Cube(favoriteNumber)}");

        //        long factorial = MathUtilities.Factorial(favoriteNumber);
        //        if (factorial != -1)
        //            Console.WriteLine($"Factorial: {factorial}");
        //        else
        //            Console.WriteLine("Factorial: Undefined for negative numbers.");

        //        // Step 3: Explore Fibonacci Sequence
        //        Console.Write("Enter N to find the Nth Fibonacci number: ");
        //        string fibonacciInput = Console.ReadLine();
        //        while (!int.TryParse(fibonacciInput, out fibonacciN) || fibonacciN < 1)
        //        {
        //            Console.WriteLine("Please enter a positive integer for N: ");
        //            fibonacciInput = Console.ReadLine();
        //        }

        //        int fibonacciResult = MathUtilities.NthFibonacci(fibonacciN);
        //        Console.WriteLine($"{fibonacciN}th Fibonacci number: {fibonacciResult}");

        //        // Step 4: Interactive Menu
        //        bool exit = false;
        //        while (!exit)
        //        {
        //            Console.WriteLine("\nWould you like to:");
        //            Console.WriteLine("1. View your profile details");
        //            Console.WriteLine("2. Perform another text analysis");
        //            Console.WriteLine("3. Perform another number analysis");
        //            Console.WriteLine("4. Compute another Fibonacci sequence");
        //            Console.WriteLine("5. Exit");

        //            Console.Write("Please enter your choice: ");
        //            string choice = Console.ReadLine();

        //            switch (choice)
        //            {
        //                case "1":
        //                    Console.WriteLine($"Your birthdate: {birthdate:yyyy-MM-dd}");
        //                    Console.WriteLine($"Your age: {age}");
        //                    Console.WriteLine($"Your bio: {bio}");
        //                    break;
        //                case "2":
        //                    Console.Write("Enter a new bio: ");
        //                    bio = Console.ReadLine();
        //                    wordCount = TextUtilities.WordCount(bio);
        //                    Console.WriteLine($"Word count: {wordCount}");
        //                    titleCaseBio = TextUtilities.ToTitleCase(bio);
        //                    Console.WriteLine($"Title Case: {titleCaseBio}");
        //                    break;
        //                case "3":
        //                    Console.Write("Enter a new lucky number: ");
        //                    favoriteNumberInput = Console.ReadLine();
        //                    while (!int.TryParse(favoriteNumberInput, out favoriteNumber))
        //                    {
        //                        Console.WriteLine("Invalid number. Please enter a valid number: ");
        //                        favoriteNumberInput = Console.ReadLine();
        //                    }
        //                    Console.WriteLine($"Is even? {MathUtilities.IsEven(favoriteNumber)}");
        //                    Console.WriteLine($"Square: {MathUtilities.Square(favoriteNumber)}");
        //                    Console.WriteLine($"Cube: {MathUtilities.Cube(favoriteNumber)}");
        //                    factorial = MathUtilities.Factorial(favoriteNumber);
        //                    if (factorial != -1)
        //                        Console.WriteLine($"Factorial: {factorial}");
        //                    else
        //                        Console.WriteLine("Factorial: Undefined for negative numbers.");
        //                    break;
        //                case "4":
        //                    Console.Write("Enter a new N to compute the Nth Fibonacci number: ");
        //                    fibonacciInput = Console.ReadLine();
        //                    while (!int.TryParse(fibonacciInput, out fibonacciN) || fibonacciN < 1)
        //                    {
        //                        Console.WriteLine("Please enter a positive integer for N: ");
        //                        fibonacciInput = Console.ReadLine();
        //                    }
        //                    fibonacciResult = MathUtilities.NthFibonacci(fibonacciN);
        //                    Console.WriteLine($"{fibonacciN}th Fibonacci number: {fibonacciResult}");
        //                    break;
        //                case "5":
        //                    Console.WriteLine("Thank you for using the Intelligent Digital Assistant!");
        //                    exit = true;
        //                    break;
        //                default:
        //                    Console.WriteLine("Invalid choice. Please try again.");
        //                    break;
        //            }
        //        }
        //    }
        //}








        //public static class TextUtilities
        //{
        //    public static int WordCount(string sentence)
        //    {
        //        string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        //        return words.Length;
        //    }

        //    public static string ToTitleCase(string sentence)
        //    {
        //        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //        for (int i = 0; i < words.Length; i++)
        //        {
        //            words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        //        }
        //        return string.Join(" ", words);
        //    }
        //}




    
