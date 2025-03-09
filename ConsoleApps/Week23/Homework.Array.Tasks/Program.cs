using Homework.Array.Tasks.StudentManagementSystem;

namespace Homework.Array.Tasks
{
    class Program
    {
        static void Main()
        {
            //Task 1:
            StudentManager manager = new StudentManager(5);
            manager.AddStudent("Aynur", 85);
            manager.AddStudent("Resad", 78);
            manager.AddStudent("Ceyhun", 92);
            manager.AddStudent("Rehim", 67);
            manager.AddStudent("Murad", 88);

            Console.WriteLine("Students:");
            manager.DisplayStudents();

            Console.WriteLine($"Highest Grade: {manager.GetHighestGrade()}");
            Console.WriteLine($"Lowest Grade: {manager.GetLowestGrade()}");
            Console.WriteLine($"Average Grade: {manager.GetAverageGrade()}");

            Console.WriteLine("\nSorting by grades:");
            manager.SortByGrade();
            manager.DisplayStudents();

            Console.WriteLine("\nSearching for Ceyhun:");
            Student found = manager.SearchByName("Ceyhun");
            if (found != null)
            {
                Console.WriteLine($"Found - Name: {found.Name}, Grade: {found.Grade}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            Console.WriteLine();



            //    //Task 2:
            //    StoreInventory store = new StoreInventory(5);

            //    store.AddProduct("Laptop", 1200.99m);
            //    store.AddProduct("Phone", 699.50m);
            //    store.AddProduct("Headphones", 149.99m);
            //    store.AddProduct("Monitor", 299.99m);
            //    store.AddProduct("Keyboard", 99.99m);

            //    Console.WriteLine("Products before sorting:");
            //    store.DisplayProducts();

            //    store.SortByPrice();
            //    Console.WriteLine("\nProducts after sorting by price:");
            //    store.DisplayProducts();

            //    Product expensive = store.FindMostExpensive();
            //    Product cheap = store.FindCheapest();
            //    Console.WriteLine($"\nMost Expensive: {expensive.Name}, Price: {expensive.Price}");
            //    Console.WriteLine($"Cheapest: {cheap.Name}, Price: {cheap.Price}");

            //    string searchName = "Phone";
            //    Product found1 = store.SearchByName(searchName);
            //    Console.WriteLine(found1 != null ? $"\nProduct Found: {found1.Name}, Price: {found1.Price}" : "\nProduct not found.");
            //    Console.WriteLine();





            //    //Task 3:
            //    HospitalRecords records = new HospitalRecords(5);
            //    records.AddPatient("Aynur", 30, 36.5);
            //    records.AddPatient("Resad", 40, 38.2);
            //    records.AddPatient("Ceyhun", 25, 37.0);
            //    records.AddPatient("Rehim", 50, 39.1);
            //    records.AddPatient("Murad", 22, 36.8);

            //    records.IdentifyFeverCases();

            //    Console.WriteLine("\nSorting patients by temperature...");
            //    records.SortPatientsByTemperature();
            //    records.DisplayPatients();

            //    Console.WriteLine("\nSearching for Murad...");
            //    Patient found2 = records.FindPatientByName("Murad");
            //    if (found != null)
            //    {
            //        Console.WriteLine($"\nFound: {found2.Name}, Age: {found2.Age}, Temperature: {found2.Temperature}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Patient not found.");
            //    }
            //    Console.WriteLine();




            //    //Task 4:
            //    Cinema cinema = new Cinema(5, 5); // 5x5 seat matrix
            //    cinema.DisplayAvailableSeats();
            //    cinema.BookSeat(2, 3);
            //    cinema.BookSeat(2, 3);
            //    cinema.DisplayAvailableSeats();
            //    Console.WriteLine();




            //    //Task 5:
            //    double[] temperatures = { 23.5, 19.2, 25.3, 22.8, 18.7, 26.1, 20.5 };
            //    WeatherStation station = new WeatherStation(temperatures);

            //    Console.WriteLine("Weather Data:");
            //    station.DisplayWeatherData();

            //    WeatherData hottest = station.GetHottestDay();
            //    Console.WriteLine($"\nHottest Day: Day {hottest.Day} with {hottest.Temperature}°C");

            //    WeatherData coldest = station.GetColdestDay();
            //    Console.WriteLine($"Coldest Day: Day {coldest.Day} with {coldest.Temperature}°C");

            //    Console.WriteLine($"\nAverage Temperature: {station.GetAverageTemperature()}°C");

            //    station.SortByTemperature();
            //    Console.WriteLine("\nSorted Weather Data by Temperature:");
            //    station.DisplayWeatherData();
            //    Console.WriteLine();





            //    //Task 6:
            //    ShoppingCart cart = new ShoppingCart(5);

            //    cart.AddItem("Apple", 0.99m, 3);
            //    cart.AddItem("Banana", 0.59m, 5);
            //    cart.AddItem("Orange", 1.29m, 2);

            //    cart.DisplayCart();

            //    cart.RemoveItem("Banana");
            //    Console.WriteLine("\nAfter removing Banana:");
            //    cart.DisplayCart();
            //    Console.WriteLine();





            //    //TAsk 7:
            //    StockMarketTracker tracker = new StockMarketTracker(5);
            //    tracker.AddStock(new DateTime(2024, 3, 1), 100.50m);
            //    tracker.AddStock(new DateTime(2024, 3, 2), 98.75m);
            //    tracker.AddStock(new DateTime(2024, 3, 3), 102.25m);
            //    tracker.AddStock(new DateTime(2024, 3, 4), 97.40m);
            //    tracker.AddStock(new DateTime(2024, 3, 5), 105.00m);

            //    Console.WriteLine("Stocks before sorting:");
            //    tracker.DisplayStocks();

            //    tracker.SortByDate();
            //    Console.WriteLine("\nStocks after sorting:");
            //    tracker.DisplayStocks();

            //    Stock highest = tracker.FindHighestPrice();
            //    Stock lowest = tracker.FindLowestPrice();
            //    decimal average = tracker.CalculateAveragePrice();

            //    Console.WriteLine($"\nHighest Price: Date: {highest.Date}, Price: {highest.Price}");
            //    Console.WriteLine($"Lowest Price: Date: {lowest.Date}, Price: {lowest.Price}");
            //    Console.WriteLine($"Average Price: {average}");
            //    Console.WriteLine();





            //    //Task 8:
            //    Chatbot bot = new Chatbot(5);
            //    bot.AddResponse("Hello", "Hi there!");
            //    bot.AddResponse("How are you?", "I'm just a bot, but I'm doing great!");

            //    Console.WriteLine(bot.GetResponse("Hello"));
            //    Console.WriteLine(bot.GetResponse("How are you?"));
            //    Console.WriteLine(bot.GetResponse("What's your name?"));    
            //    Console.WriteLine();




            //    //Task 9:
            //    LibrarySystem library = new LibrarySystem(3);
            //    library.AddBook(0, "Suç ve Ceza", "Fyodor Dostoyevski");
            //    library.AddBook(1, "1984", "George Orwell(1949)");
            //    library.AddBook(2, "Kürk Mantolu Madonna", "Sabahattin Ali");

            //    library.ViewAvailableBooks();
            //    library.BorrowBook(1);
            //    library.ViewAvailableBooks();
            //    library.ReturnBook(1);
            //    library.ViewAvailableBooks();

        }
    }
}
