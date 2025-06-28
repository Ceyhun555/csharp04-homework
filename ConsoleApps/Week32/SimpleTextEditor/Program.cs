
using System;
using UndoTextEditor.Services;

namespace UndoTextEditor
{
    class Program
    {
        static void Main()
        {
            TextEditorService service = new TextEditorService();
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Simple Text Editor ===");
                Console.WriteLine("1. Type new text");
                Console.WriteLine("2. Undo last entry");
                Console.WriteLine("3. View current text");
                Console.WriteLine("4. Clear all");
                Console.WriteLine("5. Save and exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        service.TypeNewText();
                        break;
                    case 2:
                        service.UndoLastEntry();
                        break;
                    case 3:
                        service.ViewText();
                        break;
                    case 4:
                        service.ClearAll();
                        break;
                    case 5:
                        service.SaveAndExit();
                        break;
                    default:
                        Console.WriteLine(" Invalid choice.");
                        break;
                }

                if (choice != 5)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 5);
        }
    }
}
