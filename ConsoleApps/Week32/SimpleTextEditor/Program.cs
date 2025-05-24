
using System.ComponentModel.Design.Serialization;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Simple Text Editor ===");
                Console.WriteLine("1. Type new text");
                Console.WriteLine("2. Undo last entry");
                Console.WriteLine("3. View current text");
                Console.WriteLine("4. Clear all");
                Console.WriteLine("5. Save and exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewLine();
                        break;
                    case "2":
                        UndoLastLine();
                        break;
                    case "3":
                        ViewText();
                        break;
                    case "4":
                        ClearText();
                        break;
                    case "5":
                        SaveSession();
                        Console.WriteLine("Changes saved. Exiting.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }


            }
        }

        private static void AddNewLine()
        {
            Console.Write("\nEnter new line: ");
            string newLine = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(newLine)) 
            {
                Console.WriteLine("Cannot add empty text.");
                return;
            }
        }

        private static void UndoLastLine()
        {
            
        }

        private static void ViewText()
        {
            throw new NotImplementedException();
        }

        private static void ClearText()
        {
            throw new NotImplementedException();
        }

        private static void SaveSession()
        {
            throw new NotImplementedException();
        }
    }
}
