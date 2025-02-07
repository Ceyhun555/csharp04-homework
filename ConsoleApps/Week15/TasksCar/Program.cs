namespace TasksCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Car Class Demonstration ===");

            // Create a Default Car
            Car defaultCar = new Car();
            defaultCar._year = 23;
            defaultCar.DisplayDetails();




            // Create a Custom Car
            Car customCar = new Car("Toyota", "Corolla", 2015);
            customCar.DisplayDetails();




            // Create a Fully Custom Car
            Car fullyCustomCar = new Car("Tesla", "Model 3", 2020, 40000.0m);
            fullyCustomCar.DisplayDetails();




            // Apply a discount
            fullyCustomCar.ApplyDiscount(10);
            



            // Change the price
            fullyCustomCar.UpdatePrice(35000.0m);
            



            // Display the age of the car
            int carAge = fullyCustomCar.AgeOfCar();
            Console.WriteLine($"The car's age is: {carAge} years.");




            // Display final details
            fullyCustomCar.DisplayDetails();
        }

    }
}
