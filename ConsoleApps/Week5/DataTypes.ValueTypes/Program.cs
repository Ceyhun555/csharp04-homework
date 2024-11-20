namespace DataTypes.ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I want to print Hello world

            Console.WriteLine("Hello, World!");

            //I want to print hello world same line

            //Console.Write("Hello. World2");

            //Console.Write("Hello. World3");

            /*I want to test multiline comment
             * 
             
             */

            //CSharp variables 

            /* Variables are containers for storing data values.

            In C#, there are different types of variables (defined with different keywords), for example:

            int - stores integers (whole numbers), without decimals, such as 123 or -123
            double - stores floating point numbers, with decimals, such as 19.99 or -19.99
            char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            string - stores text, such as "Hello World". String values are surrounded by double quotes
            bool - stores values with two states: true or */

            // I want to format code: shortcut ctrl+k+d
            // I want to format code: shortcut ctrl+k+d

            // type variableName = value;

            int age = 23; //32 bit signed integer

            byte age2 = 23; //8 bit unsigned integer

            short shortVal = -3000; // 16bit signed integer

            long longVal = 10000000000L; //64bit signed integer 

            Console.WriteLine(age);

            Console.WriteLine(age2);

            Console.WriteLine(shortVal);

            Console.WriteLine(longVal);

            // Display variables

            Console.WriteLine("Display variables");

            string name = "Ceyhun";

            Console.WriteLine("Hello " + name);

            Console.WriteLine("age: " + age);

            Console.WriteLine("age2 " + age2);

            Console.WriteLine("shortVal " + shortVal);

            Console.WriteLine("longVal " + longVal);

            Console.WriteLine();

            //Floating point types

            Console.WriteLine("Floating point types");


            float floatVal = 3.14f;//32 bit float pointing

            double doubleVal = 3.14;//64 bit float pointing

            decimal decimalVal = 3.14m;//128 bit float pointing

            Console.WriteLine("Float " + floatVal);

            Console.WriteLine("Double " + doubleVal);

            Console.WriteLine("Decimal " + decimalVal);

            Console.WriteLine();

            //Character type

            Console.WriteLine("Character type");

            char letter = 'A';

            char symbol = '#';

            Console.WriteLine("Char " + letter);

            Console.WriteLine("Char " + symbol);

            //Boolean type

            Console.WriteLine("Boolean type");

            bool isfalse = false;

            bool istrue = true;

            Console.WriteLine("bool " + isfalse);

            Console.WriteLine("bool " + istrue);

        }


    }
}
