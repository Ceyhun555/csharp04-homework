using System.ComponentModel;

namespace Week7.Day01.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");

            int amount = 2500;

            Console.WriteLine("amount " + amount);

            //Write a C# program that asks the user to input their age and monthly salary, then performs the following:

            //Implicitly cast the age to a double.
            //Convert the salary to an int.
            //Calculate the user's annual salary.
            //Display the user's age, monthly salary, and annual salary.
            //Example:
            // Sample Input: 
            // Age: 28
            // Monthly Salary: 3000.75

            // Output:
            // Your age as a double is: 28.0
            // Your monthly salary as an integer is: 3000
            // Your annual salary is: 36000 

            Console.WriteLine("Enter Your age");

            string ageStr = Console.ReadLine();

            int age = Convert.ToInt32(ageStr);

            

            Console.WriteLine("Enter your Monthly salary");

            string salaryStr = Console.ReadLine();

            double salary = Convert.ToDouble(salaryStr);

            string monthsStr = "12"; 

            byte months = Convert.ToByte(monthsStr);

            double annualSalary = salary * months;

            Console.WriteLine("Your age as a int is: " + age);

            Console.WriteLine("Your monthly salary as double is: " + salary);

            Console.WriteLine("Your annual salary as a double is: " + annualSalary);*/

            /*It is calculated using the formula, Perimeter of Rectangle = 2 (Length + Width).
             * The area of a rectangle is the region covered within its boundary and this can be calculated using the formula,
             * area of rectangle = length × width.*/

            /*Console.WriteLine("Enter the lenght of the room");
            
            string lenghtStr = Console.ReadLine();

            double lenght = Convert.ToDouble(lenghtStr);

            Console.WriteLine("Enter the width of the room");

            string widhtStr = Console.ReadLine();

            double widht = Convert.ToDouble(widhtStr);

            double rectangleArea = lenght * widht;

            Console.WriteLine("Your lenght of the room " + lenght);

            Console.WriteLine("Your widht of the room " + widht);

            Console.WriteLine("Your rectangleArea of the room " + rectangleArea);*/

            /*The perimeter formula for a rectangle states that P = (L + W) × 2, where P represents perimeter, L represents length, and W represents width. When you are given the dimensions of a rectangular shape,
             * you can simply plug in the values of L and W into the formula in order to solve for the perimeter.*/


            /*double perimeter = (lenght + widht) * 2;

            Console.WriteLine("Your perimeter of the room " + perimeter);

            //Try parse;


            Console.WriteLine("Enter Your age");

            string ageStr1 = Console.ReadLine();

            //int age1 = Convert.ToInt32(ageStr);

            bool parsedInt = int.TryParse(ageStr1, out int age1);

            Console.WriteLine("ParsedInt " + parsedInt);

            Console.WriteLine("age1 " + age1);

            Console.WriteLine();

            if (parsedInt == true )
            {
                Console.WriteLine("Enter valid number");
            }else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }

            Console.WriteLine();*/




            //Task 1: Celsius to Fahrenheit Conversion:

            /*Write a C# program that asks the user to input a temperature in Celsius, then performs the following:

            Convert the Celsius temperature to Fahrenheit using the formula: F = (C × 9 / 5) +32.
            Display both the Celsius and Fahrenheit values.*/


            Console.WriteLine("Enter your temperature of the room");

            string celsiusStr = Console.ReadLine();

            int celsius = Convert.ToInt32(celsiusStr);

            double fahrenheit = (celsius * 9 / 5) + 32; 

            Console.WriteLine("Your celsius of the room " + celsius);

            Console.WriteLine("Your fahrenheit of the room " + fahrenheit);

            Console.WriteLine();


            //Task 2: Area of a Circle:

            /*Write a C# program that asks the user to input the radius of a circle, then performs the following:

            Calculate the area of the circle using the formula: Area = π * r^2. -> Use Math.PI for π in C#
            Display the radius and the area of the circle*/

            Console.WriteLine("Enter radius of the circle");

            string radiusStr = Console.ReadLine();

            int radius = Convert.ToInt32(radiusStr);

            string areaFormula = "'π' * 'r' ^ 2";

            double area = Math.PI * Math.Pow(radius, 2);


            Console.WriteLine("Your radius of the circle " + radius);

            Console.WriteLine("Your area of the circle " + areaFormula);

            Console.WriteLine("Circle area " + area);

            Console.WriteLine();

            //Task 3: Simple Interest Calculator

            /*Write a C# program that asks the user to input the principal amount, the rate of interest, and the time (in years), then performs the following:

            Calculate the simple interest using the formula: Simple Interest = (Principal * Rate * Time) / 100.
            Display the calculated simple interest.*/

            Console.WriteLine("Enter the principal amount,  the rate of interest, and the time (in yeaars)");
           
            string principalAmountStr = Console.ReadLine();

            string rateStr = Console.ReadLine();

            string timeStr = Console.ReadLine();

            int principal = Convert.ToInt32(principalAmountStr);

            int rate = Convert.ToInt32(rateStr);

            int time = Convert.ToInt32(timeStr);

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("Principal amount is " + principal);

            Console.WriteLine("Rate of interest is " + rate);

            Console.WriteLine("The time (in years) " + time);

            Console.WriteLine("Simple Interest " + simpleInterest);

            Console.WriteLine();

            //Task 4: Rectangle Perimeter Calculator:

            /*Write a C# program that asks the user to input the length and width of a rectangle,
            * then calculates the perimeter using the formula: Perimeter = 2 * (Length + Width)*/

            Console.WriteLine("Enter length of a rectangle");

            string lengthStr = Console.ReadLine();

            double length = Convert.ToDouble(lengthStr);

            Console.WriteLine("Enter width of a rectangle");

            string widthStr = Console.ReadLine();   

            double width = Convert.ToDouble(widthStr);

            double perimeter1 = (length + width) * 2;
            
            Console.WriteLine("Length is " + length);

            Console.WriteLine("Width is " + width);

            Console.WriteLine("Perimeter of a rectangle is " + perimeter1);

            Console.WriteLine();

            //Task 5: Convert Minutes to Hours and Minutes

            //Write a C# program that asks the user to input a number of minutes, then converts it to hours and minutes.

            Console.WriteLine("Enter a number of minutes ");

            string minutesStr = Console.ReadLine();

            int minutes = Convert.ToInt32(minutesStr);

            int hours = minutes / 60;

            int remainMinute = minutes % 60;

            Console.WriteLine("Minutes is " + minutes + " Hours " + hours + " Remain Minute " + remainMinute);


 

            Console.WriteLine();


            //Task 6: Kilometers to Miles Converter:

            /*Write a C# program that asks the user to input a distance in kilometers,
            * then converts it to miles using the formula: Miles = Kilometers * 0.621371*/

            Console.WriteLine("Enter a distance in kilometers");

            string kilometersStr = Console.ReadLine();

            double kilometers = Convert.ToDouble(kilometersStr);

            double miles = kilometers * 0.621371;

            Console.WriteLine("A distance in kilometers is " + kilometers);

            Console.WriteLine("Miles is " + miles);

            Console.WriteLine();

            //Task 7: Average of Three Numbers:

            //Write a C# program that asks the user to input three numbers, then calculates their average.

            Console.WriteLine("Enter three numbers");

            string number1Str = Console.ReadLine();

            string number2Str = Console.ReadLine(); 

            string number3Str = Console.ReadLine();

            double number1 = Convert.ToDouble(number1Str);

            double number2 = Convert.ToDouble(number2Str);

            double number3 = Convert.ToDouble(number3Str);

            double average = (number1 + number2 + number3) / 3;

            Console.WriteLine("Number1 is " + number1);

            Console.WriteLine("Number2 is " + number2);

            Console.WriteLine("Number3 is " + number3);

            Console.WriteLine("Average is " + average);

            Console.WriteLine();

            //Task 8: Convert Days to Weeks and Days:

            //Write a C# program that asks the user to input a number of days, then converts it to weeks and remaining days.

            Console.WriteLine("Enter a number of days ");

            string dayStr = Console.ReadLine();

            int day = Convert.ToInt32(dayStr);

            int week = day / 7;

            int remainDay = week % 7;

            Console.WriteLine("Day " + day + " Week " + week + " Remain day " + remainDay);

            

            Console.WriteLine();

            //Task 9: Grams to Kilograms Converter:

            //Write a C# program that asks the user to input a weight in grams, then converts it to kilograms.

            Console.WriteLine("Enter a weight in grams");

            string gramStr = Console.ReadLine();

            double gram = Convert.ToDouble(gramStr);

            double kilogram = gram / 1000;

            Console.WriteLine("Gram is " + gram);

            Console.WriteLine("Kilogram is " + kilogram);

            Console.WriteLine();


            































        }
    }
}
