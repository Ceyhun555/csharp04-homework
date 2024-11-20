using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace If.Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*Task 1: Determine Leap Year
            *Description: Write a program that prompts the user to enter a year and determines if it is a leap year. 
            A leap year is divisible by 4 but not by 100 unless it is also divisible by 400.*/

            Console.WriteLine("Enter a year");

            string yearStr = Console.ReadLine();

            bool validYearParsing = int.TryParse(yearStr, out int year);

            if (validYearParsing == true)
            {
                bool isLeapYear = year % 4 == 0 && year % 100 != 0 && year % 400 == 0;

                if (isLeapYear == true)
                {

                    Console.WriteLine("Leap Year!");

                }
                else
                {
                    Console.WriteLine("Is not Leap Year!");
                }
            }

            else
            {
                Console.WriteLine("Invalid number please enter valid number");
            }

            Console.WriteLine();

            /*Task 2: Check if Character is Vowel or Consonant:
            Description: Write a program that takes a single character as input and checks 
            *if it is a vowel (a, e, i, o, u - case insensitive) or a consonant.*/

            Console.WriteLine("Enter a character");

            char character = Console.ReadLine()[0];

            if ((character == 'a') || (character == 'e') || (character == 'i') || (character == 'o') || (character == 'u'))
            {
                Console.WriteLine("Character is a vowel");
            }
            else if ((character >= 'a' && character <= 'z'))
            {
                Console.WriteLine("Character is a consonant");
            }

            Console.WriteLine();

            /*Task 3: Check for Weekend
            Description: Write a program that prompts the user to enter the day of the week.
            *The program should determine if the day is a weekend (Saturday or Sunday) or a weekday.*/

            Console.WriteLine("Enter the day of the week");

            string dayOfTheWeek = Console.ReadLine();

            bool validDayParsing = true;

            if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                Console.WriteLine("It's a weekend!");
            }
            else
            {
                Console.WriteLine("It's a weekday.");
            }

            Console.WriteLine();

            /*Task 4: Calculate BMI Category
            *Description: Write a program that asks the user for their weight (in kg) and height (in meters),
            calculates their Body Mass Index (BMI), and categorizes it as:*/

            /*BMI < 18.5: Underweight
            BMI 18.5–24.9: Normal weight
            BMI 25–29.9: Overweight
            BMI 30 or more: Obesity*/

            Console.WriteLine("Enter your weight in kg: ");

            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");

            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            if (bmi < 18.5)
            {
                Console.WriteLine("Category: Underweight");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Category: Normal weight");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Category: Overweight");
            }
            else
            {
                Console.WriteLine("Category: Obese");
            }

            Console.WriteLine();


            /*Task 5: Identify Triangle Type
            *Description: Write a program that asks the user for the three side lengths of a triangle and identifies if it is an Equilateral (all sides equal),
            Isosceles (two sides equal), or Scalene(all sides different) triangle.*/

            Console.WriteLine("Enter the length of the first side:");

            double sidea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side:");

            double sideb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side:");

            double sidec = Convert.ToDouble(Console.ReadLine());


            if (sidea == sideb && sideb == sidec)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (sidea == sideb || sideb == sidec || sidea == sidec)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }

            Console.WriteLine();

            /*Task 6: Determine Shipping Cost Based on Weight
            Description: Write a program that calculates the shipping cost based on package weight. The cost structure is:
            Less than or equal to 1 kg: $5
            More than 1 kg but less than or equal to 5 kg: $10
            More than 5 kg but less than or equal to 10 kg: $20
            Over 10 kg: $50*/

            /*Enter package weight in kg: 3
            Output: The shipping cost is $10.
            Enter package weight in kg: 7
            Output: The shipping cost is $20.*/

            Console.WriteLine("Enter the package weight in kg: ");

            string weightStr = Console.ReadLine();

            bool validWeight1Parsing = int.TryParse(weightStr, out int weight1);

            if (validWeight1Parsing == false)
            {
                Console.WriteLine("Enter valid number");
            }
            double cost = 0;

            if (weight1 <= 1)
            {
                cost = 5;
            }
            else if (weight1 <= 5)
            {
                cost = 10;
            }
            else if (weight1 <= 10)
            {
                cost = 20;
            }
            else
            {
                cost = 50;
            }
            Console.WriteLine("The Shipping cost is " + cost);

            Console.WriteLine();

            /*Task 7: Calculate Electricity Bill
             Description: Write a program that calculates the electricity bill based on the following rates per unit:*/

            /*0–100 units: $0.50 per unit
            101–200 units: $0.75 per unit
            201–300 units: $1.20 per unit
            Over 300 units: $1.50 per unit
            Example Input and Output:

            Enter units consumed: 150
            Output: The total bill is $112.5.
            Enter units consumed: 320
            Output: The total bill is $480.0*/

            Console.WriteLine("Enter units consumed:");

            string unitStr = Console.ReadLine();

            bool validUnitParsing = int.TryParse(unitStr, out int unit);

            if (validUnitParsing == false)
            {
                Console.WriteLine("Enter valid number");
            }
            double bill = 0;

            if (unit <= 100)
            {
                bill = unit * 0.50;
            }
            else if (unit <= 200)
            {
                bill = 100 * 0.50 + (unit - 100) * 0.75;
            }
            else if (unit <= 300)
            {
                bill = 100 * 0.50 + 100 * 0.75 + (unit - 200) * 1.20;
            }
            else
            {
                bill = 100 * 0.50 + 100 * 0.75 + 100 * 1.20 + (unit - 300) * 1.50;
            }
            Console.WriteLine("The Total Bill is: " + bill);

            Console.WriteLine();



            /*Task 8: Check if Number is Divisible by 2, 3, or 5
            Description: Write a program that prompts the user for a number and checks if it is divisible by 2, 3, or 5. Display appropriate messages based on the result.*/

            Console.WriteLine("Enter a number: ");

            string numberStr = Console.ReadLine();

            bool validNumberParsing = int.TryParse(numberStr, out int number);

            if (validNumberParsing == false)
            {
                Console.WriteLine("Enter valid number");
            }           

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2.");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3.");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("The number is divisible by 5.");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 2, 3, or 5.");
            }

            Console.WriteLine();


            /*Task 9: Ticket Price Based on Age
            Description: Write a program that calculates the ticket price based on age:*/

            /*0–3 years: Free
            4–12 years: $10
            13–59 years: $20
            60+ years: $15*/

            Console.WriteLine("Enter your age: ");

            int age = int.Parse(Console.ReadLine());

            int ticketPrice;

            if (age <= 12)
            {
                Console.WriteLine("Ticket Price is: 5");
            }
            else if (age <= 18)
            {
                Console.WriteLine("Ticket price is: 8");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Ticket price is: 12");
            }
            else
            {
                Console.WriteLine("Ticket price is: 7");
            }

            Console.WriteLine();

            /*Task 10: Determine Passing Grade
            Description: Write a program that takes a student’s grade as input and determines if they have passed.
            A grade of 50 or higher is a passing grade, while below 50 is a failing grade.*/

            Console.WriteLine("Enter  your grade");

            int grade = int.Parse(Console.ReadLine());

            if (grade > 50)
            {
                Console.WriteLine("Passed");
            }
            else if (grade < 50)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

            Console.WriteLine();

        }
    }
}
