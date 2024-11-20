using System.ComponentModel;
using System.Linq.Expressions;

namespace Week5.Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //I want to print hello world

            Console.WriteLine("Hello World!");

            //I want to print hello world same line

            Console.Write("Hello World2!");

            Console.Write("Hello World3!");

            //I want to test single-line comments

            Console.WriteLine("Hello World!");

            /*I want to test multi-line comments
             */

            //CSharp variables  

            
            

            /* Variables are containers for storing data values.

            In C#, there are different types of variables (defined with different keywords), for example:

            int - stores integers (whole numbers), without decimals, such as 123 or -123
            double - stores floating point numbers, with decimals, such as 19.99 or -19.99
            char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            string - stores text, such as "Hello World". String values are surrounded by double quotes
            bool - stores values with two states: true or false */

            // Integer type;

            int age = 23; //32 bit signed integer

            short shortVal = -3500; // 16bit signed integer

            long longVal = 10000000000L; //64bit signed integer 

            byte byteval = 250; //8bit unsigned integer 

            Console.WriteLine("integer Type:");

            Console.WriteLine(age);

            Console.WriteLine(shortVal);

            Console.WriteLine(longVal);

            Console.WriteLine(byteval);

            Console.WriteLine();

            //Float-point type;

            float floatVal = 3.14f; // 32 bit floating point

            double doubleVal = 3.1435692475; //64 bit floating point

            decimal decimalval = 14567.345m; // 128bit decimal point

            Console.WriteLine("Floating-Point types:");

            Console.WriteLine("float: " + floatVal);

            Console.WriteLine("double " + doubleVal);

            Console.WriteLine("decimal " + decimalval);

            Console.WriteLine();

            //Boolean type;

            bool istrue = true; //boolean value

            bool isfalse = false;

            Console.WriteLine("Boolean Types:");

            Console.WriteLine("true " + istrue);

            Console.WriteLine("false " + isfalse);

            Console.WriteLine();

            //Character type;

            char letter = 'A'; //single character

            char symbol = '#';

            Console.WriteLine("Character Type:");

            Console.WriteLine("char " + letter);

            Console.WriteLine("char " + symbol);

            Console.WriteLine();

            //type variableName = value;

            Console.WriteLine("Type variableName:");

            string name = "Ceyhun";

            Console.WriteLine(name);

            int myNum = 10;

            Console.WriteLine(myNum);

            Console.WriteLine();

            //Other types

            double mydoubleNum = 10.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            Console.WriteLine("Other types:");

            Console.WriteLine("double " + mydoubleNum);

            Console.WriteLine("char " + myLetter);

            Console.WriteLine("bool " + myBool);

            Console.WriteLine("string " + myText);

            Console.WriteLine();

            //Display variables;

            string firstname = "Ceyhun ";

            string lastname = "Ismayilov";

            string fullname = firstname + lastname;

            Console.WriteLine("Display variables:");

            Console.WriteLine(fullname);

            Console.WriteLine();

            //For numaric values;

            Console.WriteLine("For numeric values:");

            int x = 8;

            int y = 10;

            Console.WriteLine(x.ToString() + y.ToString());

            Console.WriteLine("Hello" + "World");

            Console.WriteLine();

            int x1 = 7; int y1 = 9; int z1 = 24;

            Console.WriteLine(x1 + y1 + z1);

            int x2, y2, z2;

            x2 = y2 = z2 = 55;

            Console.WriteLine(x2 + y2 + z2); //One line;

            Console.WriteLine();

            //Identifiers 

            /*The general rules for naming variables are:  
            Names can contain letters, digits and the underscore character(_)
            Names must begin with a letter or underscore
            Names should start with a lowercase letter, and cannot contain whitespace
            Names are case -sensitive("myVar" and "myvar" are different variables)
            Reserved words(like C# keywords, such as int or double) cannot be used as names*/

            Console.WriteLine("Identifiers:");

            int minutesPerHour = 60;

            Console.WriteLine("int " + minutesPerHour);

            int m = 60;

            Console.WriteLine(m);

            //CSharp data types;

            /*A data type specifies the size and type of variable values.

            It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory, but it will also make your code more maintainable and readable. The most common data types are:

            Data Type	Size	Description
            int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool	1 bit	Stores true or false values
            char	2 bytes	Stores a single character/letter, surrounded by single quotes
            string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes*/


            int myNum2 = 5000;
            long myNum3 = 12000000000L;
            float myNum4 = 8.5F;
            double myNum5 = 25.6D;

            Console.WriteLine("CSharp data types:");

            Console.WriteLine("int " + myNum2);
            Console.WriteLine("long " + myNum3);
            Console.WriteLine("float " + myNum4);
            Console.WriteLine("double " + myNum5);

            Console.WriteLine();

            //Scientific numbers;

            float f1 = 34e5f;
            double d1 = 14E7d;

            Console.WriteLine("Scientific:");

            Console.WriteLine(f1);
            Console.WriteLine(d1);

            Console.WriteLine("float " + f1);
            Console.WriteLine("double " + d1);

            Console.WriteLine();

            //Booleans

            bool isGameFun = true;
            bool isSushiTasty = false;

            Console.WriteLine("Booleans:");

            Console.WriteLine(isGameFun); //Outputs true;

            Console.WriteLine(isSushiTasty); //Outputs false;

            Console.WriteLine("bool " + isGameFun);

            Console.WriteLine("bool " + isSushiTasty);

            Console.WriteLine();

            //Characters;

            char myVariant = 'D';

            Console.WriteLine("Character:");

            Console.WriteLine("char " + myVariant);

            Console.WriteLine();

            //Strings;

            string sport = "Karate";

            Console.WriteLine("Strings:");

            Console.WriteLine("string " + sport);

            Console.WriteLine();



        }
    }
}
