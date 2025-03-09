namespace Homework.Array.Tasks.LibraryManagementSystem
{
    class LibrarySystem
    {
        private Book[] books;

        public LibrarySystem(int size)
        {
            books = new Book[size];
        }

        public void AddBook(int index, string title, string author)
        {
            if (index >= 0 && index < books.Length)
            {
                books[index] = new Book(title, author);
            }
        }

        public void ViewAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].IsAvailable)
                {
                    Console.WriteLine($"{i + 1}. {books[i].Title} by {books[i].Author}");
                }
            }
        }

        public void BorrowBook(int index)
        {
            if (index >= 0 && index < books.Length && books[index] != null && books[index].IsAvailable)
            {
                books[index].IsAvailable = false;
                Console.WriteLine($"You borrowed: {books[index].Title}");
            }
            else
            {
                Console.WriteLine("Book is not available or invalid index.");
            }
        }

        public void ReturnBook(int index)
        {
            if (index >= 0 && index < books.Length && books[index] != null && !books[index].IsAvailable)
            {
                books[index].IsAvailable = true;
                Console.WriteLine($"You returned: {books[index].Title}");
            }
            else
            {
                Console.WriteLine("Invalid return request.");
            }
        }
    }
}
