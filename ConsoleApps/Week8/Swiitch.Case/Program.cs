using System;
using System.IO;
using System.Security.Authentication;

namespace Swiitch.Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*Task 1: Fruit Price Checker
            *Description: Write a program that takes the name of a fruit (e.g., apple, banana, orange) as input and prints the price per kilogram of that fruit.
            *Use a switch statement with these prices:*/
            /*Apple: $3 per kg
            Banana: $2 per kg
            Orange: $4 per kg
            Default: Fruit not available*/


            Console.WriteLine("Enter the name of the fruit:");

            string fruit = Console.ReadLine().ToLower();

            bool fruitParsing = true;

            switch (fruit)
            {
                case "apple":
                    Console.WriteLine("The price of apple perkg is; 3$ ");
                    break;
                case "banana":
                    Console.WriteLine("The price of banana perkg is: 2$ ");
                    break;
                case "orange":
                    Console.WriteLine("The price of orange perkg is: 4$ ");
                    break;
                default:
                    Console.WriteLine("Sorry, we don't have a price for that fruit.");
                    break;

            }
            Console.WriteLine();

            /*Task 2: Traffic Light Actions
            Description: Write a program that takes a traffic light color (Red, Yellow, Green) as input and prints the action for each color.*/

            /*Red: Stop
            Yellow: Get Ready
            Green: Go*/

            Console.WriteLine("Enter the traffic light color (Red, Yellow, Green): ");

            string color = Console.ReadLine();

            switch (color.ToLower())
            {
                case "red":
                    Console.WriteLine("Stop");
                    break;
                case "yellow":
                    Console.WriteLine("Prepare to stop");
                    break;
                case "green":
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Invalid color");
                    break;
            }
            Console.WriteLine();

            /*Task 3: Zodiac Sign by Month
            Description: Write a program that takes a month (1–12) as input and prints the corresponding Zodiac signs.*/

            /*January: Capricorn, Aquarius
            February: Aquarius, Pisces
            March: Pisces, Aries
            April: Aries, Taurus
            May: Taurus, Gemini
            June: Gemini, Cancer
            July: Cancer, Leo
            August: Leo, Virgo
            September: Virgo, Libra
            October: Libra, Scorpio
            November: Scorpio, Sagittarius
            December: Sagittarius, Capricorn*/

            Console.WriteLine("Enter a month (1–12):");

            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("Capricorn (Dec 22 – Jan 19) && Aquarius (Jan 20 – Feb 18)");
                    break;
                case 2:
                    Console.WriteLine("Aquarius (Jan 20 – Feb 18) && Pisces (Feb 19 – Mar 20)");
                    break;
                case 3:
                    Console.WriteLine("Pisces (Feb 19 – Mar 20) && Aries (Mar 21 – Apr 19)");
                    break;
                case 4:
                    Console.WriteLine("Aries (Mar 21 – Apr 19) && Taurus (Apr 20 – May 20)");
                    break;
                case 5:
                    Console.WriteLine("Taurus (Apr 20 – May 20) && Gemini (May 21 – Jun 20)");
                    break;
                case 6:
                    Console.WriteLine("Gemini (May 21 – Jun 20) && Cancer (Jun 21 – Jul 22)");
                    break;
                case 7:
                    Console.WriteLine("Cancer (Jun 21 – Jul 22) && Leo (Jul 23 – Aug 22)");
                    break;
                case 8:
                    Console.WriteLine("Leo (Jul 23 – Aug 22) && Virgo (Aug 23 – Sep 22)");
                    break;
                case 9:
                    Console.WriteLine("Virgo (Aug 23 – Sep 22) && Libra (Sep 23 – Oct 22)");
                    break;
                case 10:
                    Console.WriteLine("Libra (Sep 23 – Oct 22) && Scorpio (Oct 23 – Nov 21)");
                    break;
                case 11:
                    Console.WriteLine("Scorpio (Oct 23 – Nov 21) && Sagittarius (Nov 22 – Dec 21)");
                    break;
                case 12:
                    Console.WriteLine("Sagittarius (Nov 22 – Dec 21) && Capricorn (Dec 22 – Jan 19)");
                    break;
                default:
                    Console.WriteLine("Invalid month. Please enter a number from 1 to 12.");
                    break;
            }
            Console.WriteLine();

            /*Task 4: Movie Rating System
            Description: Write a program that takes a rating (1–5) as input and prints feedback for each rating.*/

            /*5: Excellent
            4: Good
            3: Average
            2: Poor
            1: Very Poor
            Default: Invalid rating*/

            Console.WriteLine("Enter a movie rating (1-5): ");

            int rating = int.Parse(Console.ReadLine());

            switch (rating)
            {
                case 1:
                    Console.WriteLine("Terrible - Would not recommend!");
                    break;
                case 2:
                    Console.WriteLine("Poor - Not worth the time.");
                    break;
                case 3:
                    Console.WriteLine("Average - It was okay.");
                    break;
                case 4:
                    Console.WriteLine("Good - Worth watching.");
                    break;
                case 5:
                    Console.WriteLine("Excellent - Highly recommended!");
                    break;
                default:
                    Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
                    break;
            }
            Console.WriteLine();

            /*Task 5: Meal Type by Time of Day           
            Description: Write a program that takes an hour (0–23) as input and determines which meal is typical for that time.*/

            /*5–10: Breakfast
            11–15: Lunch
            16–20: Dinner
            21–4: Late Snack
            Default: Invalid time*/


            Console.WriteLine("Enter an hour (0-23):");

            double hour = double.Parse(Console.ReadLine());

            {
                switch (hour)
                {
                    case double h when (h > 5 && h < 12):
                        Console.WriteLine("MealType is: Breakfast");
                        break;
                    case double h when (h > 11 && h < 18):
                        Console.WriteLine("MealType is: Lunch");
                        break;
                    case double h when (h > 17 && h < 22):
                        Console.WriteLine("MealType is: Dinner");
                        break;
                    default:
                    case double h when (h > 21 && h < 6):
                        Console.WriteLine("Late Night Snack / No Meal");
                        break;
                }
                Console.WriteLine();

                /* Switch case when istifade ele.*/

                /*Task 6: Water Temperature State
                Description: Write a program that takes a temperature in Celsius as input and determines the state of water.*/
                /*Less than 0: Solid(Ice)
                0–99: Liquid
                100 or above: Gas(Steam)*/

                Console.WriteLine("Enter the temperature in celsius");

                double temperature = double.Parse(Console.ReadLine());

                {
                    switch (temperature)
                    {
                        case double t when (t <= 0):
                            Console.WriteLine("State is: Solid (ice)");
                            break;
                        case double t when (t > 0 && t < 100):
                            Console.WriteLine("State is: Liquid (water)");
                            break;
                        case double t when (t >= 100):
                            Console.WriteLine("State is: Gas (steam)");
                            break;
                        default:
                            Console.WriteLine("Unknown state");
                            break;
                    }

                }
            }
            Console.WriteLine();

            /*Task 7: Day Part of the Week
            Description: Write a program that takes an hour of the day (0–23) as input and outputs the part of the day:*/

            /*0–5: Midnight to Early Morning
            6–11: Morning
            12–17: Afternoon
            18–21: Evening
            22–23: Night*/
            Console.WriteLine("Enter an hour of the day (0-23): ");

            double hour2 = double.Parse(Console.ReadLine());

            switch (hour)
            {
                case double h when (h >= 0 && h < 12):
                    Console.WriteLine("It's morning.");
                    break;
                case double h when (h >= 12 && h < 18):
                    Console.WriteLine("It's afternoon.");
                    break;
                case double h when (h >= 18 && h < 21):
                    Console.WriteLine("It's evening.");
                    break;
                case double h when (h >= 21 && h <= 23):
                    Console.WriteLine("It's night.");
                    break;
                default:
                    Console.WriteLine("Invalid hour. Please enter a number between 0 and 23.");
                    break;
            }
            Console.WriteLine();
            //When ile yaz.


            /*Task 8: Coffee Order Size
           Description: Write a program that takes a coffee size (S, M, L) as input and prints the volume in milliliters:*/
            /*S: 250 ml
            M: 350 ml
            L: 500 ml
            Default: Invalid size*/

            Console.WriteLine("Enter coffee size (S, M, L): ");

            char size = char.ToUpper(Console.ReadKey().KeyChar);

            switch (size)
            {
                case 'S':
                    Console.WriteLine("Volume: 200 ml");
                    break;
                case 'M':
                    Console.WriteLine("Volume: 350 ml");
                    break;
                case 'L':
                    Console.WriteLine("Volume: 500 ml");
                    break;
                default:
                    Console.WriteLine("Invalid size. Please enter S, M, or L.");
                    break;
            }
            Console.WriteLine();


            /*Task 9: Planet Order from the Sun
            Description: Write a program that takes the planet's order from the sun (1-8) as input and prints the planet name.*/

            /*1:Mercury
            2:Venus
            3:Earth
            4:Mars
            5:Jupiter
            6:Saturn
            7:Uranus
            8:Neptune*/

            Console.WriteLine("Enter the planet's order from the Sun (1-8): ");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Order cannot be null or empty.");
            }
            else
            {
                int order;

                if (int.TryParse(input, out order))
                {
                    switch (order)
                    {
                        case 1:
                            Console.WriteLine("Mercury");
                            break;
                        case 2:
                            Console.WriteLine("Venus");
                            break;
                        case 3:
                            Console.WriteLine("Earth");
                            break;
                        case 4:
                            Console.WriteLine("Mars");
                            break;
                        case 5:
                            Console.WriteLine("Jupiter");
                            break;
                        case 6:
                            Console.WriteLine("Saturn");
                            break;
                        case 7:
                            Console.WriteLine("Uranus");
                            break;
                        case 8:
                            Console.WriteLine("Neptune");
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
            Console.WriteLine();


            /*Task 10: Type of Triangle by Sides
            Description: Write a program that takes three side lengths of a triangle as input and identifies the type of triangle.*/

            /*Equilateral: All three sides are equal.
            Isosceles: Exactly two sides are equal.
            Scalene: All three sides are different.*/

            Console.WriteLine("Enter the first side length:");

            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second side length:");

            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third side length:");

            int side3 = int.Parse(Console.ReadLine());

            if (side1 <= 0 || side2 <= 0 || side3 <= 0 ||
                side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
            else
            {
                switch (true)
                {
                    case bool _ when side1 == side2 && side2 == side3:
                        Console.WriteLine("The triangle is Equilateral.");
                        break;

                    case bool _ when side1 == side2 || side2 == side3 || side1 == side3:
                        Console.WriteLine("The triangle is Isosceles.");
                        break;

                    case bool _ when side1 != side2 && side2 != side3 && side1 != side3:
                        Console.WriteLine("The triangle is Scalene.");
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            Console.WriteLine();



            /*Task 11: Season by Hemisphere and Month
            Description: Write a program that takes a hemisphere (North, South) and a month number (1-12) as input and outputs the season.*/

            Console.WriteLine("Enter hemisphere (North or South): ");

            string hemisphere = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Enter month number (1-12): ");

            int month1 = int.Parse(Console.ReadLine());

            switch (hemisphere)
            {
                case "north":
                    switch (month1)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("Winter");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Spring");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Summer");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Autumn");
                            break;
                        default:
                            Console.WriteLine("Unknown");
                            break;
                    }

                    break;
                case "south":
                    switch (month1)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("Summer");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Autumn");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Winter");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Spring");
                            break;
                        default:
                            Console.WriteLine("Unknown");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            Console.WriteLine();


            /*Task 12: Greeting Based on Time and Language
            Description: Write a program that takes an hour (0-23) and a language code (EN, ES, FR) as input and provides a greeting.*/

            Console.Write("Enter the hour (0-23): ");

            int hour4 = int.Parse(Console.ReadLine());

            Console.Write("Enter the language code (EN, ES, FR): ");

            string language = Console.ReadLine().ToUpper();

            string greeting = "";

            switch (hour)
            {
                case double n when (n >= 0 && n <= 11): // Morning
                    switch (language)
                    {
                        case "EN":
                            Console.WriteLine("Good Morning");
                            break;
                        case "ES":
                            Console.WriteLine("Buenos Días");
                            break;
                        case "FR":
                            Console.WriteLine("Bonjour");
                            break;
                        default:
                            Console.WriteLine("Invalid language");
                            break;
                    }
                    break;
                case double n when (n >= 12 && n <= 17): // Afternoon
                    switch (language)
                    {
                        case "EN":
                            Console.WriteLine("Good Afternoon");
                            break;
                        case "ES":
                            Console.WriteLine("Buenas Tardes");
                            break;
                        case "FR":
                            Console.WriteLine("Bon Après-midi");
                            break;
                        default:
                            Console.WriteLine("Invalid language");
                            break;
                    }
                    break;
                case double n when (n >= 18 && n <= 23): // Evening
                    switch (language)
                    {
                        case "EN":
                            Console.WriteLine("Good Evening");
                            break;
                        case "ES":
                            Console.WriteLine("Buenas Noches");
                            break;
                        case "FR":
                            Console.WriteLine("Bonsoir");
                            break;
                        default:
                            Console.WriteLine("Invalid language");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid hour input");
                    break;
            }
            Console.WriteLine(greeting);

            Console.WriteLine();




            /*Task 13: Age Group Classification
            Description: Write a program that takes an age as input and categorizes it as:*/

            Console.WriteLine("Enter your age: ");

            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case int n when (n >= 0 && n <= 12):
                    Console.WriteLine("Child");
                    break;
                case int n when (n >= 13 && n <= 17):
                    Console.WriteLine("Teenager");
                    break;
                case int n when (n >= 18 && n <= 64):
                    Console.WriteLine("Adult");
                    break;
                case int n when (n >= 65):
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("Invalid age entered");
                    break;
            }
            Console.WriteLine();


            /*Task 14: Bank Transaction Type
            Description: Write a program that takes a transaction code (D for Deposit, W for Withdrawal,
            T for Transfer) and prints a message confirming the transaction type*/

            Console.WriteLine("Enter transaction code (D for Deposit, W for Withdrawal, T for Transfer): ");

            char transactionCode = Char.ToUpper(Console.ReadKey().KeyChar);

            Console.WriteLine();

            switch (transactionCode)
            {
                case 'D':
                    Console.WriteLine("Transaction Type: Deposit");
                    break;
                case 'W':
                    Console.WriteLine("Transaction Type: Withdrawal");
                    break;
                case 'T':
                    Console.WriteLine("Transaction Type: Transfer");
                    break;
                default:
                    Console.WriteLine("Invalid transaction code.");
                    break;
            }
            Console.WriteLine();


            /*Task 15: Book Genre Description
            Description: Write a program that takes a book genre code 
            (F for Fiction, NF for Non-Fiction, M for Mystery, SF for Sci-Fi) and outputs a description.*/

            Console.WriteLine("Enter a book genre code (F, NF, M, SF): ");

            string genreCode = Console.ReadLine();

            switch (genreCode)
            {
                case "F":
                    Console.WriteLine("Fiction: A genre that contains imaginative or invented stories.");
                    break;
                case "NF":
                    Console.WriteLine("Non-Fiction: A genre that provides factual and real information.");
                    break;
                case "M":
                    Console.WriteLine("Mystery: A genre focused on suspense, solving crimes, and uncovering secrets.");
                    break;
                case "SF":
                    Console.WriteLine("Sci-Fi: A genre involving futuristic concepts, technology, and space exploration.");
                    break;
                default:
                    Console.WriteLine("Invalid genre code. Please enter F, NF, M, or SF.");
                    break;
            }
            Console.WriteLine();




        }
    }
}
