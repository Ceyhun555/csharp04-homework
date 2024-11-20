namespace DataTypes.Castings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Type casting;

            /*Type casting is when you assign a value of one data type to another type.

            In C#, there are two types of casting:

            Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char*/

            //Implicit casting;


            int myInt = 10;

            double myDouble = myInt; //Automatic casting int to double

            Console.WriteLine("Iplicit casting");

            Console.WriteLine(myInt);

            Console.WriteLine(myDouble);

            Console.WriteLine();

            //Explicit casting;

            double myDouble1 = 11.6;

            int myInt1 = (int) myDouble1; //Manual casting

            Console.WriteLine("Explicit casting");

            Console.WriteLine(myDouble1);

            Console.WriteLine(myInt1);

            Console.WriteLine();

            //Type Conversion methods;\

            /*It is also possible to convert data types explicitly by using built-in methods, 
             * such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):*/

            int myInt2 = 15;
            double myDouble2 = 8.6;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt2)); //convert int to string
            Console.WriteLine(Convert.ToDouble(myInt2)); //convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble2)); //convert double to int
            Console.WriteLine(Convert.ToString(myBool)); //convert bool to string

            Console.WriteLine();

            //Understanding type casting;
            //Create a C# console application to demonstrate both implicit and explicit casting, along with type conversion using the Convert class.

            /*Instructions:
            * Declare variables of different types such as int, double, float, char, etc.
            Perform implicit casting where smaller types are automatically cast to larger types (e.g., int to double).
            Perform explicit casting where larger types are manually cast to smaller types (e.g., double to int). Show how data loss occurs (e.g., losing decimal precision when casting double to int).
            Demonstrate the use of Convert methods to safely convert values between types (e.g., Convert.ToInt32(), Convert.ToDouble()).
            Print the results of each casting operation to the console.*/

            int age2 = 25; // Declare an integer variable 'age' and assign it the value 25
            double salary = 50000.75; // Declare a double variable 'salary' and assign it the value 50000.75

            // Implicit casting (int to double)
            double newAge = age2; // Implicitly cast the integer 'age' to a double and assign it to 'newAge'
            Console.WriteLine($"Implicit Casting - Age as double: {newAge}"); // Print the value of 'newAge' to the console

            // Explicit casting (double to int)
            int roundedSalary = (int)salary; // Explicitly cast the double 'salary' to an integer and assign it to 'roundedSalary'
            Console.WriteLine($"Explicit Casting - Rounded Salary: {roundedSalary}"); // Print the value of 'roundedSalary' to the console

            // Conversion using Convert
            int ageFromString = Convert.ToInt32("25"); // Convert the string "25" to an integer using the Convert.ToInt32 method and assign it to 'ageFromString'
            Console.WriteLine($"Convert from string to int: {ageFromString}"); // Print the value of 'ageFromString' to the console

            Console.WriteLine();


        }
}
}
