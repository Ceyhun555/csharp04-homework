namespace PracticeTasksBook
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("=== BookClass Demonstration === ");

            //Create a Default Book.
            Book defaultBook = new Book();
            defaultBook.DisplayDetails();


            //Create a Custom Book.
            Book customBook = new Book("C# Programming", "Jhon Doe", 2020);
            customBook.DisplayDetails();



            //Create a Fully Custom Book.
            Book fullyCustomBook = new Book("Advanced C# Programming", "Jane Smith", 2023, 49.99m);
            fullyCustomBook.DisplayDetails();


            //Apply a discount.
            fullyCustomBook.DiscountPrice(10);
            Console.WriteLine($"The price after 10% discount is: ${fullyCustomBook.Price}");


            //Change the Price.
            fullyCustomBook.ChangePrice(39.99m);
            Console.WriteLine($"The price has been updated to: ${fullyCustomBook.Price}");


            //Update the year of publication.
            fullyCustomBook.UpdateYearPublished(2024);
            Console.WriteLine($"The year of publication has been updated to: ${fullyCustomBook.YearPublished}");



            //Display final details.
            fullyCustomBook.DisplayDetails();







        }
    }
}
