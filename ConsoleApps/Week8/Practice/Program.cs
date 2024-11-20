namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int kilogram1 = 5;

            int gram1 = 5000;

            Console.WriteLine($"{kilogram1} {gram1}");

            Console.WriteLine("kilogram  {0} gram {1}", kilogram1, gram1);

            string kilogram3 = string.Concat("kilogram1", " ", kilogram1, " ", "gram1", " ", gram1);


            //Task 1: Celsius to Fahrenheit Conversion:

            /*Write a C# program that asks the user to input a temperature in Celsius, then performs the following:

            Convert the Celsius temperature to Fahrenheit using the formula: F = (C × 9 / 5) +32.
            Display both the Celsius and Fahrenheit values.*/

            Console.WriteLine("Enter temperature of the weather");

            string celciusStr = Console.ReadLine();

           
            bool validIntParsing = int.TryParse(celciusStr , out int celcius);

            if (validIntParsing == true)
            {
                double fahrenheith = (celcius * 9 / 5) + 32;

                string celcius1 = $"Temperature of the weahter is {celcius} {fahrenheith}";

                Console.WriteLine(celcius1);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }

            
            Console.WriteLine();

            

            Console.WriteLine();

            //Task 2: Area of a Circle:

            /*Write a C# program that asks the user to input the radius of a circle, then performs the following:

            Calculate the area of the circle using the formula: Area = π * r^2. -> Use Math.PI for π in C#
            Display the radius and the area of the circle*/

            Console.WriteLine("Enter raidus of the circle");

            string radiusStr = Console.ReadLine();

            bool validIntParsing1 = int.TryParse(radiusStr , out int radius);

            if (validIntParsing1 == true)
            {
                string areaFormula = "'π' * 'r' ^ 2";

                double area = Math.PI * Math.Pow(radius, 2);

                string area1 = $"Radius of the circle {radius} {area}";

                Console.WriteLine(area1);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }

            

            Console.WriteLine();

           

            Console.WriteLine();

            //Task 3: Simple Interest Calculator

            /*Write a C# program that asks the user to input the principal amount, the rate of interest, and the time (in years), then performs the following:

            Calculate the simple interest using the formula: Simple Interest = (Principal * Rate * Time) / 100.
            Display the calculated simple interest.*/

            Console.WriteLine("Enter principal amount");
            
            string principalAmountStr = Console.ReadLine();

            Console.WriteLine("Enter the rate of interest");

            string rateStr = Console.ReadLine();

            Console.WriteLine("The time (in years)");

            string timeStr = Console.ReadLine();

            

            bool validPrincipalParsing = int.TryParse(principalAmountStr, out int principal);

            bool validRateParsing = int.TryParse(rateStr, out int rate);

            bool validTimeParsing= int.TryParse(timeStr, out int time);

            if (validPrincipalParsing == true && validRateParsing == true && validTimeParsing == true) 
            {
                double simpleInterest = (principal * rate * time) / 100;

                string simpleInterest1 = $"Simple interest is  {principal} {rate} {time} {simpleInterest}";

                Console.WriteLine(simpleInterest1);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }

            

            Console.WriteLine();

            

            Console.WriteLine();

            //Task 4: Rectangle Perimeter Calculator:

            /*Write a C# program that asks the user to input the length and width of a rectangle,
            * then calculates the perimeter using the formula: Perimeter = 2 * (Length + Width)*/

            Console.WriteLine("Enter length of a rectangle");

            string lengthStr = Console.ReadLine();

            

            Console.WriteLine("Enter width of a rectangle");

            string widthStr = Console.ReadLine();

            

            bool validLengthParsing = int.TryParse(lengthStr, out int length);

            bool validWidthParsing = double.TryParse(widthStr, out double width);

            if (validLengthParsing == true && validWidthParsing == true)
            {
                double perimeter = (length + width) * 2;

                string perimeter1 = $"Perimeter is {length} {width} {perimeter}";

                Console.WriteLine(perimeter1);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }

            
           

            Console.WriteLine();

            //Task 5: Convert Minutes to Hours and Minutes

            //Write a C# program that asks the user to input a number of minutes, then converts it to hours and minutes.

            Console.WriteLine("Enter a number of minutes");

            string minutesStr = Console.ReadLine();

            

            

            bool validMinuteParsing = int.TryParse(minutesStr, out int minutes);

            if (validMinuteParsing == true)
            {
                int hours = minutes / 60;

                int remainMinute = minutes % 60;

                string minute = $"Minutes is {minutes} {hours} {remainMinute}";

                Console.WriteLine(minute);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }


            

           
            Console.WriteLine();

            //Task 6: Kilometers to Miles Converter:

            /*Write a C# program that asks the user to input a distance in kilometers,
            * then converts it to miles using the formula: Miles = Kilometers * 0.621371*/

            Console.WriteLine("Enter a distance in kilometers");

            string kilometersStr = Console.ReadLine();
            

            

            bool validKilometersParsing =int.TryParse(kilometersStr, out int kilometers);

            if (validKilometersParsing == true)
            {
                double miles = kilometers * 0.621371;

                string kilometers1 = $"A distance in kilometers is {kilometers} {miles}";

                Console.WriteLine(kilometers1);

                Console.WriteLine("Success");

            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }
            

            

            Console.WriteLine();


            //Task 7: Average of Three Numbers:

            //Write a C# program that asks the user to input three numbers, then calculates their average.

            Console.WriteLine("Enter three numbers");

            string number1Str = Console.ReadLine();

            string number2Str = Console.ReadLine();

            string number3Str = Console.ReadLine();

            

            bool validNumber1Parsing = double.TryParse(number1Str, out double number1);

            bool validNumber2Parsing = double.TryParse(number2Str, out double number2);

            bool validNumber3Parsing = double.TryParse(number3Str, out double number3);

            if (validNumber1Parsing == true &&  validNumber2Parsing == true && validNumber3Parsing == true)       
            {

                double average = (number1 + number2 + number3) / 3;

                string average1 = $"Average is {number1} {number2} {number3} {average}";

                Console.WriteLine(average1);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }

           

            


            //Task 8: Convert Days to Weeks and Days:

            //Write a C# program that asks the user to input a number of days, then converts it to weeks and remaining days.

            Console.WriteLine("Enter a number of days ");

            string dayStr = Console.ReadLine();

            bool validDayParsing = int.TryParse(dayStr, out int day);

            if (validDayParsing == true)
            {

                int week = day / 7;

                int remainDay = day % 7;

                string day1 = $" Day is {day} {week} {remainDay}";

                Console.WriteLine(day1);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }
            


            

            Console.WriteLine();

            //Task 9: Grams to Kilograms Converter:

            //Write a C# program that asks the user to input a weight in grams, then converts it to kilograms.

            Console.WriteLine("Enter a weight in grams");

            string gramStr = Console.ReadLine();

            bool validGramParsing = double.TryParse(gramStr, out double gram);

            if (validGramParsing == true)
            {
                double kilogram = gram / 1000;

                string kilogram2 = $"Kilogram is {gram} {kilogram}";

                string kilogramDisplayText = "Kilogram is {gram} {kilogram}";

                Console.WriteLine(kilogramDisplayText, gram, kilogram);

                Console.WriteLine(kilogram2);

                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Invalid number, please enter valid number");
            }
            
           

            Console.WriteLine();












        }
    }
}
