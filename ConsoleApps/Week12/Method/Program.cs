namespace Method
{
    internal class Program
    {
        static void Main()
        {
            /*Task 1: Creating and Calling a Simple Method
            Description
            Write a program with a method that prints a greeting message to the console.

            Explanation
            Methods allow you to group code into reusable blocks. Define a method with void to indicate it doesn’t return any value, and call it from the Main method.

            Sample Input and Output
            No input required.
            Output:

            Hello, welcome to C# programming! */

            MethodTasks.Greet();


            /*Task 2: Method with Parameters
            Description
            Write a program with a method that takes a name as a parameter and prints a personalized greeting.

            Explanation
            Methods can accept input values (parameters). Pass a string parameter to the method and use it in the greeting.

            Sample Input and Output
            Input:

            Enter your name: Alice
            Output:

            Hello, Alice! Welcome to C# programming.  */

            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine();
            PersonalizedGreet(name);


            /*Task 3: Method with Return Value
            Description
            Write a program with a method that calculates the square of a number and returns the result.

            Explanation
            Use the return keyword to send a value back to the calling method.

            Sample Input and Output
            Input:

            Enter a number: 4
            Output:

            The square of 4 is 16.  */

            Console.Write("\nEnter a number: ");
            int number = int.Parse(Console.ReadLine());
            int square = CalculateSquare(number);
            Console.WriteLine($"The square of {number} is {square}");


            /*Task 4: Method Overloading
            Description
            Write a program with two methods named Add. One method should take two integers, and the other should take three integers.

            Explanation
            Method overloading allows you to define multiple methods with the same name but different parameter lists.

            Sample Input and Output
            Input:

            Enter two numbers: 3, 5
            Enter three numbers: 2, 4, 6
            Output:

            Sum of two numbers: 8
            Sum of three numbers: 12  */

            Console.Write("\nEnter two numbers: ");
            string[] twoNumbers = Console.ReadLine().Split(',');
            int sumTwo = Add(int.Parse(twoNumbers[0]), int.Parse(twoNumbers[1]));
            Console.WriteLine($"Sum of two numbers: {sumTwo}");

            Console.Write("Enter three numbers: ");
            string[] threeNumbers = Console.ReadLine().Split(',');
            int sumThree = Add(int.Parse(threeNumbers[0]), int.Parse(threeNumbers[1]), int.Parse(threeNumbers[2]));
            Console.WriteLine($"Sum of three numbers: {sumThree}");


            /*Task 5: Passing Parameters by Value
            Description
            Write a program to demonstrate passing parameters by value. Create a method that modifies a number, but the change doesn’t affect the original value.

            Explanation
            When you pass parameters by value, a copy of the variable is sent to the method, leaving the original value unchanged.

            Sample Input and Output
            Input:

            Enter a number: 10
            Output:

            Original value: 10
            Modified value inside method: 20
            Value after method call: 10  */

            Console.Write("\nEnter a number: ");
            int originalValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nOriginal value: {originalValue}");
            ModifyValue(originalValue);
            Console.WriteLine($"Value after method call: {originalValue}");


            /*Task 6: Passing Parameters by Reference
            Description
            Write a program to demonstrate passing parameters by reference. Create a method that doubles a number, and the change affects the original variable.

            Explanation
            Use the ref keyword to pass the reference of the variable to the method.

            Sample Input and Output
            Input:

            Enter a number: 5
            Output:

            Value before method call: 5
            Value inside method: 10
            Value after method call: 10  */

            int refValue = 5;
            Console.WriteLine($"\nValue before method call: {refValue}");
            DoubleValue(ref refValue);
            Console.WriteLine($"Value after method call: {refValue}");

            /*Task 7: Using out Parameters
            Description
            Write a program with a method that calculates the quotient and remainder of two numbers using out parameters.

            Explanation
            The out keyword allows a method to return multiple values through its parameters.

            Sample Input and Output
            Input:

            Enter dividend: 10
            Enter divisor: 3
            Output:

            Quotient: 3
            Remainder: 1 */

            Console.Write("\nEnter dividend: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            CalculateQuotientAndRemainder(dividend, divisor, out int quotient, out int remainder);
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");

            /*Task 8: Method with Optional Parameters
            Description
            Write a program with a method that calculates the area of a rectangle. If only one parameter is provided, treat it as a square.

            Explanation
            Optional parameters allow you to call a method with fewer arguments. Assign default values to parameters.

            Sample Input and Output
            Input:

            Enter length: 5
            Enter width (or press Enter to skip): (skipped)
            Output:

            Area: 25  */

            Console.Write("\nEnter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width (or press Enter to skip): ");
            string widthInput = Console.ReadLine();
            int width = string.IsNullOrWhiteSpace(widthInput) ? 0 : int.Parse(widthInput);
            Console.WriteLine($"Area: {CalculateArea(length, width)}");


            /*Task 9: Recursion in Methods
            Description
            Write a program to calculate the factorial of a number using recursion.

            Explanation
            Recursion occurs when a method calls itself. It’s useful for problems that can be divided into smaller sub-problems.

            Sample Input and Output
            Input:

            Enter a number: 5
            Output:

            Factorial of 5 is 120 */

            Console.Write("\nEnter a number to calculate its factorial: ");
            int factNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {factNumber} is {Factorial(factNumber)}");

            /*Task 10: Using Method to Work with Arrays
            Description
            Write a program with a method that takes an array of integers and returns the largest element.

            Explanation
            Pass an array as a parameter to the method and iterate through it to find the maximum value.

            Sample Input and Output
            Input:

            Enter array elements (comma-separated): 3, 7, 1, 9, 5
            Output:

            Largest element: 9  */

            Console.Write("\nEnter array elements (comma-separated): ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Console.WriteLine($"Largest element: {FindLargestElement(array)}");

            /*Task 11: Real-World Scenario - Simple Calculator
            Description
            Write a program with methods to perform basic calculator operations: addition, subtraction, multiplication, and division.

            Explanation
            Create separate methods for each operation. Call these methods based on user input.

            Sample Input and Output
            Input:

            Enter first number: 8
            Enter second number: 4
            Choose operation (+, -, *, /): /
            Output:

            Result: 2  */


            Console.Write("\nEnter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Choose operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = operation switch
            {
                '+' => Add(firstNumber, secondNumber),
                '-' => Subtract(firstNumber, secondNumber),
                '*' => Multiply(firstNumber, secondNumber),
                '/' => Divide(firstNumber, secondNumber),
                _ => throw new InvalidOperationException("Invalid operation")
            };
            Console.WriteLine($"Result: {result}");

        }
       
        //Task 2:

        static void PersonalizedGreet(string name) => Console.WriteLine($"Hello, {name}! Welcome to C# programmming.");

        //Task 3:
        static int CalculateSquare(int number) => number * number;

        //Task 4:
        static int Add(int a, int b) => a + b;
        static int Add(int a, int b, int c) => a + b + c;

        //Task 5:
        static void ModifyValue(int value)
        {
            value *= 2;
            Console.WriteLine($"Modified value inside method: {value}");
        }

        //Task 6:
        static void DoubleValue(ref int value)
        {
            value *= 2;
            Console.WriteLine($"Value inside method: {value}");
        }

        //Task 7:
        static void CalculateQuotientAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        //Task 8:
        static int CalculateArea(int length, int width = 0) => width == 0 ? length * length : length * width;

        //Task 9:
        static int Factorial(int number) => number == 0 ? 1 : number * Factorial(number - 1);

        //Task 10:
        static int FindLargestElement(int[] array)
        {
            int largest = array[0];
            foreach (int num in array)
            {
                if (num > largest) largest = num;
            }
            return largest;
        }

        //Task 11:
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");







    }
}
