namespace Calculator.Task
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

           
            Console.WriteLine("Simple Calculator");

            while (true)
            {
                Console.WriteLine("\nEnter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = calc.Add(num1, num2);
                        break;
                    case "-":
                        result = calc.Subtract(num1, num2);
                        break;
                    case "*":
                        result = calc.Multiply(num1, num2);
                        break;
                    case "/":
                        result = calc.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                
                Console.WriteLine("\nDo you want to view the calculation history? (yes/no)");
                if (Console.ReadLine()?.ToLower() == "yes")
                {
                    calc.DisplayHistory();
                }


                Console.WriteLine("\nDo you want to perform another calculation? (yes/no)");
                if (Console.ReadLine()?.ToLower() == "no")
                {
                    break;
                }
            }
        }
    }

}
