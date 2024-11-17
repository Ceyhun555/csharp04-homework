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
             * Qusestion.
            Description: Learn how to display text on the console.
             * answer. 
             * 
             * wip2
            Description: Learn how to display text on the console. 




            Question: What is the correct syntax to output "Hello, World!" in C#?

            a)print("Hello, World!");
            b)Console.WriteLine("Hello, World!");
            c)echo "Hello, World!";
            d)printf("Hello, World!");*/

            Console.WriteLine("Basic Output in C#:");

            int score = 0;

            char correctAnswer = 'b';

            while (true)
            {

                Console.WriteLine("Question 1: What is the correct syntax to output \"Hello, World!\" in C#?");

                Console.WriteLine("a)print(\"Hello, World!\")");
                Console.WriteLine("b)Console.WriteLine(\"Hello, World!\")");
                Console.WriteLine("c)echo \"Hello, World!\":");
                Console.WriteLine("d)printf(\"Hello, World!\")");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer;
                bool isCorrectAnswerParsing = char.TryParse(Console.ReadLine(), out userAnswer);

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
            Console.WriteLine();


            /*Question 2: Data Types - String
            Description: Understand which data types are used for text.

            Question: Which data type is used to store text in C#?

            a)text
            b)char
            c)string
            d)txt  */

            char correctAnswer1 = 'c';

            while (true)
            {
                Console.WriteLine("Question 2: Data Types - String");
                Console.WriteLine("a)text");
                Console.WriteLine("b)char");
                Console.WriteLine("c)string");
                Console.WriteLine("d)txt");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer1;
                bool isCorrectAnswer1Parsing = char.TryParse(Console.ReadLine(), out userAnswer1);


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
            Console.WriteLine();


            /*Question 3: Arithmetic Operators
            Description: Identify operators used for basic arithmetic.

            Question: Which operator is used to add two numbers in C#?

            a)*
            b)+
            c)&
            d)% */

            char correctAnswer2 = 'b';

            while (true)
            {
                Console.WriteLine("Question 3: Which operator is used to add two numbers in C#?");
                Console.WriteLine("a)*");
                Console.WriteLine("b)+");
                Console.WriteLine("c)&");
                Console.WriteLine("d)%");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer2;
                bool isCorrectAnswer2Parsing = char.TryParse(Console.ReadLine(), out userAnswer2);


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
            Console.WriteLine();


            /*Question 4: Declaring Variables
            Description: Understand how to declare a variable in C#.

            Question: How do you create an integer variable named "x" with the value 5?

            a) int x = 5;
            b) x int = 5;
            c) int x = "5";
            d) 5 = int x; */

            char correctAnswer3 = 'a';

            while (true)
            {
                Console.WriteLine("Question 4: How do you create an integer variable named \"x\" with the value 5?");
                Console.WriteLine("a) int x = 5;");
                Console.WriteLine("b) x int = 5;");
                Console.WriteLine("c) int x = \"5\";");
                Console.WriteLine("d) 5 = int x;");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer3;
                bool isCorrectAnswer3Parsing = char.TryParse(Console.ReadLine(), out userAnswer3);


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
            Console.WriteLine();


            /*Question 5: Conditional Statements
            Description: Learn the keywords for conditional statements.

            Question: Which keyword is commonly used to create a basic conditional statement in C#?

            a) if
            b) case
            c) switch
            d) goto */

            char correctAnswer4 = 'a';

            while (true)
            {
                Console.WriteLine("Question 5: Which keyword is commonly used to create a basic conditional statement in C#?");
                Console.WriteLine("a) if");
                Console.WriteLine("b) case");
                Console.WriteLine("c) switch");
                Console.WriteLine("d) goto");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer4;
                bool isCorrectAnswer4Parsing = char.TryParse(Console.ReadLine(), out userAnswer4);


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
            Console.WriteLine();


            /*Question 6: Basic Loops - While Loop
            Description: Understand the basics of a while loop.

            Question: How do you start a while loop in C#?

            a)while x > y {}
            b)while (x > y) {}
            c)while x > y: {}
            d)while (x > y):  */

            char correctAnswer5 = 'b';

            while (true)
            {
                Console.WriteLine("Question 6: How do you start a while loop in C#?");
                Console.WriteLine("a)while x > y {}");
                Console.WriteLine("b)while (x > y) {}");
                Console.WriteLine("c)while x > y: {}");
                Console.WriteLine("d)while (x > y):");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer5;
                bool isCorrectAnswer5Parsing = char.TryParse(Console.ReadLine(), out userAnswer5);


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
            Console.WriteLine();


            /*Question 7: Breaking Out of Loops
            Description: Know how to exit a loop before it naturally ends.

            Question: Which keyword is used to exit a loop in C#?

            a)stop
            b)end
            c)break
            d)exit  */

            char correctAnswer6 = 'c';

            while (true)
            {
                Console.WriteLine("Question 7: Which keyword is used to exit a loop in C#?");
                Console.WriteLine("a)stop");
                Console.WriteLine("b)end");
                Console.WriteLine("c)break");
                Console.WriteLine("d)exit");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer6;
                bool isCorrectAnswer6Parsing = char.TryParse(Console.ReadLine(), out userAnswer6);


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
            Console.WriteLine();


            /*Question 8: Comparison Operators
            Description: Recognize operators used for comparisons.

            Question: Which operator is used to compare two values in C#?

            a)<>
            b)>
            c)<<
            d)||  */

            char correctAnswer7 = 'b';

            while (true)
            {
                Console.WriteLine("Question 8: Which operator is used to compare two values in C#?");
                Console.WriteLine("a)<>");
                Console.WriteLine("b)>");
                Console.WriteLine("c)<<");
                Console.WriteLine("d)||");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer7;
                bool isCorrectAnswer7Parsing = char.TryParse(Console.ReadLine(), out userAnswer7);


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
            Console.WriteLine();


            /*Question 9: Logical Operators
            Description: Identify operators used to combine conditions.

            Question: Which operator can be used to combine two conditions in C#?

            a)&
            b)|
            c)&&
            d)$$ */

            char correctAnswer8 = 'c';

            while (true)
            {
                Console.WriteLine("Question 9: Which operator can be used to combine two conditions in C#?");
                Console.WriteLine("a)&");
                Console.WriteLine("b)|");
                Console.WriteLine("c)&&");
                Console.WriteLine("d)$$");
                Console.WriteLine();
                Console.Write("Your answer is: ");
                char userAnswer8;
                bool isCorrectAnswer8Parsing = char.TryParse(Console.ReadLine(), out userAnswer8);


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
            Console.WriteLine();


            /*Question 10: For Loop Syntax
            Description: Understand the syntax for for loops in C#.

            Question: How do you start a for loop in C#?

            a)for (int i = 0; i < 5; i++) {}
            b)for int i = 0 to 5 {}
            c)foreach (i in range(5)) {}
            d)for each i = 0; i < 5 */

            char correctAnswer9 = 'a';

            while (true)
            {
                Console.WriteLine("Question 10: How do you start a for loop in C#?");
                Console.WriteLine("a)for (int i = 0; i < 5; i++) {}");
                Console.WriteLine("b)for int i = 0 to 5 {}");
                Console.WriteLine("c)foreach (i in range(5)) {}");
                Console.WriteLine("d)for each i = 0; i < 5");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer9;
                bool isCorrectAnswer9Parsing = char.TryParse(Console.ReadLine(), out userAnswer9);


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
            Console.WriteLine();


            /*Question 11: Multi-Line Comments
            Description: Learn how to create comments that span multiple lines.

            Question: What is the correct syntax for a multi-line comment in C#?

            //  a)/* comment */
            //  b)// comment
            //  c) # comment
            //  d) **comment **   */

            char correctAnswer10 = 'a';

            while (true)
            {
                Console.WriteLine("Question 11: What is the correct syntax for a multi-line comment in C#?");
                Console.WriteLine("a)/* comment */");
                Console.WriteLine("b)// comment");
                Console.WriteLine("c) # comment");
                Console.WriteLine("d) **comment **");
                Console.WriteLine();
                Console.Write("Your answer is: ");
                char userAnswer10;
                bool isCorrectAnswer10Parsing = char.TryParse(Console.ReadLine(), out userAnswer10);


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
            Console.WriteLine();


            /*Question 12: Float Variables
            Description: Understand how to create variables with decimal values.

            Question: How do you create a variable with a floating point value in C#?

            a)float f = 5.99f;
            b)int f = 5.99;
            c)double f = "5.99";
            d)num f = 5.99f; */

            char correctAnswer11 = 'a';

            while (true)
            {
                Console.WriteLine("Question 12: How do you create a variable with a floating point value in C#?");
                Console.WriteLine("a)float f = 5.99f;");
                Console.WriteLine("b)int f = 5.99;");
                Console.WriteLine("c)double f = \"5.99\";");
                Console.WriteLine("d)num f = 5.99f;");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer11;
                bool isCorrectAnswer11Parsing = char.TryParse(Console.ReadLine(), out userAnswer11);


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
             Console.WriteLine();


            /*Question 13: Value and Reference Types
            Description: Recognize the difference between value types and reference types.

            Question: Which of the following is a reference type in C#?

            a)int
            b)string
            c)bool
            d)char  */

            char correctAnswer12 = 'b';

            while (true)
            {
                Console.WriteLine("Question 13: Which of the following is a reference type in C#?");
                Console.WriteLine("a)int");
                Console.WriteLine("b)string");
                Console.WriteLine("c)bool");
                Console.WriteLine("d)char");
                Console.WriteLine();
                Console.Write("Your answer is: ");
                char userAnswer12;
                bool isCorrectAnswer12Parsing = char.TryParse(Console.ReadLine(), out userAnswer12);


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
            Console.WriteLine();

            /*Question 14: Loop Types in C#
            Description: Identify the different types of loops in C#.

            Question: Which is NOT a loop type in C#?

            a)while
            b)do-while
            c)foreach
            d)repeat  */

            char correctAnswer13 = 'd';

            while (true)
            {
                Console.WriteLine("Question 14: Which is NOT a loop type in C#?");
                Console.WriteLine("a)while");
                Console.WriteLine("b)do-while");
                Console.WriteLine("c)foreach");
                Console.WriteLine("d)repeat");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer13;
                bool isCorrectAnswer13Parsing = char.TryParse(Console.ReadLine(), out userAnswer13);


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
            Console.WriteLine();


            /*Question 15: Type Casting
            Description: Understand the process of casting between data types in C#.

            Question: Which syntax is correct for casting an int to double?

            a)(double)x
            b)[double]x
            c){double}x
            d)convert(double, x)  */

            char correctAnswer14 = 'a';

            while (true)
            {
                Console.WriteLine("Question 15: Which syntax is correct for casting an int to double?");
                Console.WriteLine("a)(double)x");
                Console.WriteLine("b)[double]x");
                Console.WriteLine("c){double}x");
                Console.WriteLine("d)convert(double, x)");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer14;
                bool isCorrectAnswer14Parsing = char.TryParse(Console.ReadLine(), out userAnswer14);


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
            Console.WriteLine();


            /*Question 16: Ternary Operator
            Description: Learn how the ternary operator works in conditional expressions.

            Question: Which is the correct syntax for a ternary operator in C#?

            a)x ? y : z
            b)x ? y ? z
            c)x : y ? z
            d)x : (y) : z  */

            char correctAnswer15 = 'a';

            while (true)
            {
                Console.WriteLine("Question 16: Which is the correct syntax for a ternary operator in C#?");
                Console.WriteLine("a)x ? y : z");
                Console.WriteLine("b)x ? y ? z");
                Console.WriteLine("c)x : y ? z");
                Console.WriteLine("d)x : (y) : z");
                Console.WriteLine();
                Console.Write("Enter your answer: ");
                char userAnswer15;
                bool isCorrectAnswer15Parsing = char.TryParse(Console.ReadLine(), out userAnswer15);


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
            Console.WriteLine();

            Console.WriteLine($"Quiz Complete! You scored {score} out of 16.");

            
            







        }
    }
}
