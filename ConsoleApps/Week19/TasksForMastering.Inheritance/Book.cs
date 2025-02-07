namespace TasksForMastering.Inheritance
{
    class Book : LibraryItem
    {
        public void DisplayAccessibleMembers()
        {
            Title = "C# Programming";
            Author = "John Doe";

            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }

    }





}