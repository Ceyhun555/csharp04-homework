namespace User.Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //User Input;

            /*Get User Input
            You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.

            In the following example, the user can input his or hers username, which is stored in the variable userName. Then we print the value of userName:*/

            // Type your username and press enter 

            Console.WriteLine("Enter username");
            
            // Create a string variable and get user input from the keyborad and store it in the variable

            string username = Console.ReadLine();

            // Print the value of the variable (username), which will display the input value

            Console.WriteLine("Username is: " + "Ceyhun");

            Console.WriteLine();

            // User input and numbers:

            /*Luckily, for you, you just learned from the previous chapter (Type Casting),
            *that you can convert any type explicitly, by using one of the Convert.To methods:*/

            Console.WriteLine("Enter your age");

            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + 23);

            Console.WriteLine();

            //User input and type conversion:

            /*Build a C# console application that takes user input for two numbers and performs basic arithmetic operations on them.
            * Convert the user input from string to appropriate data types for performing the calculations.*/

            /*Instructions:
            * Prompt the user to input two numbers using Console.ReadLine().
            Convert the input strings to int or double using Convert.ToInt32() or Convert.ToDouble().
            Perform basic operations like addition, subtraction, multiplication, and division on the two numbers.
            Display the results of each operation to the user.*/

            // Prompt the user to enter the first number
            Console.WriteLine("Enter the first number: ");

            // Read the user input and store it in a string variable
            string firstInput = Console.ReadLine();

            // Convert the input string to a double
            double number1 = Convert.ToDouble(firstInput);

            // Prompt the user to enter the second number
            Console.WriteLine("Enter the second number: ");

            // Read the user input and store it in a string variable
            string secondInput = Console.ReadLine();

            // Convert the input string to a double
            double number2 = Convert.ToDouble(secondInput);

            // Perform addition and store the result
            double sum = number1 + number2;

            // Perform subtraction and store the result
            double difference = number1 - number2;

            // Perform multiplication and store the result
            double product = number1 * number2;

            // Perform division and store the result
            double quotient = number1 / number2;

            // Print the sum to the console
            Console.WriteLine($"Sum: {sum}");

            // Print the difference to the console
            Console.WriteLine($"Difference: {difference}");

            // Print the product to the console
            Console.WriteLine($"Product: {product}");

            // Print the quotient to the console
            Console.WriteLine($"Quotient: {quotient}");

            // Challange task (optional):

            /*Write a C# program that asks the user to input their age and monthly salary, then performs the following:

            Implicitly cast the age to a double.
            Convert the salary to an int.
            Calculate the user's annual salary.
            Display the user's age, monthly salary, and annual salary.*/

            // Sample Input: 
            // Age: 28
            // Monthly Salary: 3000.75

            // Output:
            // Your age as a double is: 28.0
            // Your monthly salary as an integer is: 3000
            // Your annual salary is: 36000

            Console.WriteLine();









        }
    }
}
