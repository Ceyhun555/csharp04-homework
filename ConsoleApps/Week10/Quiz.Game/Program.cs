using static System.Net.Mime.MediaTypeNames;
using System;
using System.Xml.Linq;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Quiz.Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quiz Questions for C# Beginners

            //Task1:
            /*Question 1: Basic Output in C#
            Description: Learn how to display text on the console.
    
            Question: What is the correct syntax to output "Hello, World!" in C#?

            a)print("Hello, World!");
            b)Console.WriteLine("Hello, World!");
            c)echo "Hello, World!";
            d)printf("Hello, World!");*/

            Console.WriteLine("Basic Output in C#:");

            int score = 0;

            char correctAnswer = 'b';

            Console.WriteLine("Question 1: What is the correct syntax to output \"Hello, World!\" in C#?");

            Console.WriteLine("a)print(\"Hello, World!\")");
            Console.WriteLine("b)Console.WriteLine(\"Hello, World!\")");
            Console.WriteLine("c)echo \"Hello, World!\":");
            Console.WriteLine("d)printf(\"Hello, World!\")");
            Console.WriteLine();

            while (true)
            {


                Console.Write("Enter your answer: ");
                string userInput = Console.ReadLine();
                bool isCorrectAnswerParsing = char.TryParse(userInput, out char userAnswer);

                if (isCorrectAnswerParsing == true && (userAnswer == 'a' || userAnswer == 'b' || userAnswer == 'c' || userAnswer == 'd'))
                {

                    if (userAnswer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;

                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 2: Data Types - String
            Description: Understand which data types are used for text.

            Question: Which data type is used to store text in C#?

            a)text
            b)char
            c)string
            d)txt  */

            char correctAnswer1 = 'c';

            Console.WriteLine("Question 2: Data Types - String");
            Console.WriteLine("a)text");
            Console.WriteLine("b)char");
            Console.WriteLine("c)string");
            Console.WriteLine("d)txt");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput1 = Console.ReadLine();
                bool isCorrectAnswer1Parsing = char.TryParse(userInput1, out char userAnswer1);

                if (isCorrectAnswer1Parsing == true && (userAnswer1 == 'a' || userAnswer1 == 'b' || userAnswer1 == 'c' || userAnswer1 == 'd'))
                {
                    if (userAnswer1 == correctAnswer1)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 3: Arithmetic Operators
            Description: Identify operators used for basic arithmetic.

            Question: Which operator is used to add two numbers in C#?

            a)*
            b)+
            c)&
            d)% */

            char correctAnswer2 = 'b';

            Console.WriteLine("Question 3: Which operator is used to add two numbers in C#?");
            Console.WriteLine("a)*");
            Console.WriteLine("b)+");
            Console.WriteLine("c)&");
            Console.WriteLine("d)%");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput2 = Console.ReadLine();
                bool isCorrectAnswer2Parsing = char.TryParse(userInput2, out char userAnswer2);

                if (isCorrectAnswer2Parsing == true && (userAnswer2 == 'a' || userAnswer2 == 'b' || userAnswer2 == 'c' || userAnswer2 == 'd'))
                {
                    if (userAnswer2 == correctAnswer2)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 4: Declaring Variables
            Description: Understand how to declare a variable in C#.

            Question: How do you create an integer variable named "x" with the value 5?

            a) int x = 5;
            b) x int = 5;
            c) int x = "5";
            d) 5 = int x; */

            char correctAnswer3 = 'a';

            Console.WriteLine("Question 4: How do you create an integer variable named \"x\" with the value 5?");
            Console.WriteLine("a) int x = 5;");
            Console.WriteLine("b) x int = 5;");
            Console.WriteLine("c) int x = \"5\";");
            Console.WriteLine("d) 5 = int x;");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput3 = Console.ReadLine();
                bool isCorrectAnswer3Parsing = char.TryParse(userInput3, out char userAnswer3);

                if (isCorrectAnswer3Parsing == true && (userAnswer3 == 'a' || userAnswer3 == 'b' || userAnswer3 == 'c' || userAnswer3 == 'd'))
                {

                    if (userAnswer3 == correctAnswer3)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 5: Conditional Statements
            Description: Learn the keywords for conditional statements.

            Question: Which keyword is commonly used to create a basic conditional statement in C#?

            a) if
            b) case
            c) switch
            d) goto */

            char correctAnswer4 = 'a';

            Console.WriteLine("Question 5: Which keyword is commonly used to create a basic conditional statement in C#?");
            Console.WriteLine("a) if");
            Console.WriteLine("b) case");
            Console.WriteLine("c) switch");
            Console.WriteLine("d) goto");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput4 = Console.ReadLine();
                bool isCorrectAnswer4Parsing = char.TryParse(userInput4, out char userAnswer4);

                if (isCorrectAnswer4Parsing == true && (userAnswer4 == 'a' || userAnswer4 == 'b' || userAnswer4 == 'c' || userAnswer4 == 'd'))
                {
                    if (userAnswer4 == correctAnswer4)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 6: Basic Loops - While Loop
            Description: Understand the basics of a while loop.

            Question: How do you start a while loop in C#?

            a)while x > y {}
            b)while (x > y) {}
            c)while x > y: {}
            d)while (x > y):  */

            char correctAnswer5 = 'b';

            Console.WriteLine("Question 6: How do you start a while loop in C#?");
            Console.WriteLine("a)while x > y {}");
            Console.WriteLine("b)while (x > y) {}");
            Console.WriteLine("c)while x > y: {}");
            Console.WriteLine("d)while (x > y):");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput5 = Console.ReadLine();
                bool isCorrectAnswer5Parsing = char.TryParse(userInput5, out char userAnswer5);

                if (isCorrectAnswer5Parsing == true && (userAnswer5 == 'a' || userAnswer5 == 'b' || userAnswer5 == 'c' || userAnswer5 == 'd'))
                {
                    if (userAnswer5 == correctAnswer5)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 7: Breaking Out of Loops
            Description: Know how to exit a loop before it naturally ends.

            Question: Which keyword is used to exit a loop in C#?

            a)stop
            b)end
            c)break
            d)exit  */

            char correctAnswer6 = 'c';

            Console.WriteLine("Question 7: Which keyword is used to exit a loop in C#?");
            Console.WriteLine("a)stop");
            Console.WriteLine("b)end");
            Console.WriteLine("c)break");
            Console.WriteLine("d)exit");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput6 = Console.ReadLine();
                bool isCorrectAnswer6Parsing = char.TryParse(userInput6, out char userAnswer6);

                if (isCorrectAnswer6Parsing == true && (userAnswer6 == 'a' || userAnswer6 == 'b' || userAnswer6 == 'c' || userAnswer6 == 'd'))
                {
                    if (userAnswer6 == correctAnswer6)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 8: Comparison Operators
            Description: Recognize operators used for comparisons.

            Question: Which operator is used to compare two values in C#?

            a)<>
            b)>
            c)<<
            d)||  */

            char correctAnswer7 = 'b';

            Console.WriteLine("Question 8: Which operator is used to compare two values in C#?");
            Console.WriteLine("a)<>");
            Console.WriteLine("b)>");
            Console.WriteLine("c)<<");
            Console.WriteLine("d)||");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput7 = Console.ReadLine();
                bool isCorrectAnswer7Parsing = char.TryParse(userInput7, out char userAnswer7);

                if (isCorrectAnswer7Parsing == true && (userAnswer7 == 'a' || userAnswer7 == 'b' || userAnswer7 == 'c' || userAnswer7 == 'd'))
                {
                    if (userAnswer7 == correctAnswer7)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 9: Logical Operators
            Description: Identify operators used to combine conditions.

            Question: Which operator can be used to combine two conditions in C#?

            a)&
            b)|
            c)&&
            d)$$ */

            char correctAnswer8 = 'c';

            Console.WriteLine("Question 9: Which operator can be used to combine two conditions in C#?");
            Console.WriteLine("a)&");
            Console.WriteLine("b)|");
            Console.WriteLine("c)&&");
            Console.WriteLine("d)$$");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Your answer is: ");
                string userInput8 = Console.ReadLine();
                bool isCorrectAnswer8Parsing = char.TryParse(userInput8, out char userAnswer8);

                if (isCorrectAnswer8Parsing == true && (userAnswer8 == 'a' || userAnswer8 == 'b' || userAnswer8 == 'c' || userAnswer8 == 'd'))
                {
                    if (userAnswer8 == correctAnswer8)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 10: For Loop Syntax
            Description: Understand the syntax for for loops in C#.

            Question: How do you start a for loop in C#?

            a)for (int i = 0; i < 5; i++) {}
            b)for int i = 0 to 5 {}
            c)foreach (i in range(5)) {}
            d)for each i = 0; i < 5 */

            char correctAnswer9 = 'a';

            Console.WriteLine("Question 10: How do you start a for loop in C#?");
            Console.WriteLine("a)for (int i = 0; i < 5; i++) {}");
            Console.WriteLine("b)for int i = 0 to 5 {}");
            Console.WriteLine("c)foreach (i in range(5)) {}");
            Console.WriteLine("d)for each i = 0; i < 5");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput9 = Console.ReadLine();
                bool isCorrectAnswer9Parsing = char.TryParse(userInput9, out char userAnswer9);

                if (isCorrectAnswer9Parsing == true && (userAnswer9 == 'a' || userAnswer9 == 'b' || userAnswer9 == 'c' || userAnswer9 == 'd'))
                {
                    if (userAnswer9 == correctAnswer9)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 11: Multi-Line Comments
            Description: Learn how to create comments that span multiple lines.

            Question: What is the correct syntax for a multi-line comment in C#?

            //  a)/* comment */
            //  b)// comment
            //  c) # comment
            //  d) **comment **   */

            char correctAnswer10 = 'a';

            Console.WriteLine("Question 11: What is the correct syntax for a multi-line comment in C#?");
            Console.WriteLine("a)/* comment */");
            Console.WriteLine("b)// comment");
            Console.WriteLine("c) # comment");
            Console.WriteLine("d) **comment **");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Your answer is: ");
                string userInput10 = Console.ReadLine();
                bool isCorrectAnswer10Parsing = char.TryParse(userInput10, out char userAnswer10);

                if (isCorrectAnswer10Parsing == true && (userAnswer10 == 'a' || userAnswer10 == 'b' || userAnswer10 == 'c' || userAnswer10 == 'd'))
                {

                    if (userAnswer10 == correctAnswer10)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 12: Float Variables
            Description: Understand how to create variables with decimal values.

            Question: How do you create a variable with a floating point value in C#?

            a)float f = 5.99f;
            b)int f = 5.99;
            c)double f = "5.99";
            d)num f = 5.99f; */

            char correctAnswer11 = 'a';

            Console.WriteLine("Question 12: How do you create a variable with a floating point value in C#?");
            Console.WriteLine("a)float f = 5.99f;");
            Console.WriteLine("b)int f = 5.99;");
            Console.WriteLine("c)double f = \"5.99\";");
            Console.WriteLine("d)num f = 5.99f;");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput11 = Console.ReadLine();
                bool isCorrectAnswer11Parsing = char.TryParse(userInput11, out char userAnswer11);

                if (isCorrectAnswer11Parsing == true && (userAnswer11 == 'a' || userAnswer11 == 'b' || userAnswer11 == 'c' || userAnswer11 == 'd'))
                {
                    if (userAnswer11 == correctAnswer11)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }


            }
            Console.WriteLine();


            /*Question 13: Value and Reference Types
            Description: Recognize the difference between value types and reference types.

            Question: Which of the following is a reference type in C#?

            a)int
            b)string
            c)bool
            d)char  */

            char correctAnswer12 = 'b';

            Console.WriteLine("Question 13: Which of the following is a reference type in C#?");
            Console.WriteLine("a)int");
            Console.WriteLine("b)string");
            Console.WriteLine("c)bool");
            Console.WriteLine("d)char");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Your answer is: ");
                string userInput12 = Console.ReadLine();
                bool isCorrectAnswer12Parsing = char.TryParse(userInput12, out char userAnswer12);

                if (isCorrectAnswer12Parsing == true && (userAnswer12 == 'a' || userAnswer12 == 'b' || userAnswer12 == 'c' || userAnswer12 == 'd'))
                {
                    if (userAnswer12 == correctAnswer12)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();

            /*Question 14: Loop Types in C#
            Description: Identify the different types of loops in C#.

            Question: Which is NOT a loop type in C#?

            a)while
            b)do-while
            c)foreach
            d)repeat  */

            char correctAnswer13 = 'd';

            Console.WriteLine("Question 14: Which is NOT a loop type in C#?");
            Console.WriteLine("a)while");
            Console.WriteLine("b)do-while");
            Console.WriteLine("c)foreach");
            Console.WriteLine("d)repeat");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput13 = Console.ReadLine();
                bool isCorrectAnswer13Parsing = char.TryParse(userInput13, out char userAnswer13);

                if (isCorrectAnswer13Parsing == true && (userAnswer13 == 'a' || userAnswer13 == 'b' || userAnswer13 == 'c' || userAnswer13 == 'd'))
                {
                    if (userAnswer13 == correctAnswer13)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 15: Type Casting
            Description: Understand the process of casting between data types in C#.

            Question: Which syntax is correct for casting an int to double?

            a)(double)x
            b)[double]x
            c){double}x
            d)convert(double, x)  */

            char correctAnswer14 = 'a';
            Console.WriteLine("Question 15: Which syntax is correct for casting an int to double?");
            Console.WriteLine("a)(double)x");
            Console.WriteLine("b)[double]x");
            Console.WriteLine("c){double}x");
            Console.WriteLine("d)convert(double, x)");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput14 = Console.ReadLine();
                bool isCorrectAnswer14Parsing = char.TryParse(userInput14, out char userAnswer14);

                if (isCorrectAnswer14Parsing == true && (userAnswer14 == 'a' || userAnswer14 == 'b' || userAnswer14 == 'c' || userAnswer14 == 'd'))
                {
                    if (userAnswer14 == correctAnswer14)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();


            /*Question 16: Ternary Operator
            Description: Learn how the ternary operator works in conditional expressions.

            Question: Which is the correct syntax for a ternary operator in C#?

            a)x ? y : z
            b)x ? y ? z
            c)x : y ? z
            d)x : (y) : z  */

            char correctAnswer15 = 'a';

            Console.WriteLine("Question 16: Which is the correct syntax for a ternary operator in C#?");
            Console.WriteLine("a)x ? y : z");
            Console.WriteLine("b)x ? y ? z");
            Console.WriteLine("c)x : y ? z");
            Console.WriteLine("d)x : (y) : z");
            Console.WriteLine();

            while (true)
            {

                Console.Write("Enter your answer: ");
                string userInput15 = Console.ReadLine();
                bool isCorrectAnswer15Parsing = char.TryParse(userInput15, out char userAnswer15);

                if (isCorrectAnswer15Parsing == true && (userAnswer15 == 'a' || userAnswer15 == 'b' || userAnswer15 == 'c' || userAnswer15 == 'd'))
                {
                    if (userAnswer15 == correctAnswer15)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a or b or c or d option!");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Quiz Complete! You scored {score} out of 16.");










        }
    }
}
