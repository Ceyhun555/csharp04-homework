namespace TextEditor.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Text Editor Menu:");
                Console.WriteLine("1. Append Text");
                Console.WriteLine("2. Show Text");
                Console.WriteLine("3. Save Text to File");
                Console.WriteLine("4. Load Text from File");
                Console.WriteLine("5. Make Text Uppercase");
                Console.WriteLine("6. Make Text Lowercase");
                Console.WriteLine("7. Add Line Break");
                Console.WriteLine("8. Clear Text");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter text to append: ");
                        string appendText = Console.ReadLine();
                        editor.AppendText(appendText);
                        break;

                    case "2":
                        Console.WriteLine("Current Text: ");
                        Console.WriteLine(editor.GetText());
                        break;

                    case "3":
                        Console.Write("Enter file name to save: ");
                        string saveFileName = Console.ReadLine();
                        editor.SaveToFile(saveFileName);
                        break;

                    case "4":
                        Console.Write("Enter file name to load: ");
                        string loadFileName = Console.ReadLine();
                        editor.LoadFromFile(loadFileName);
                        break;

                    case "5":
                        editor.MakeUpperCase();
                        Console.WriteLine("Text converted to uppercase.");
                        break;

                    case "6":
                        editor.MakeLowerCase();
                        Console.WriteLine("Text converted to lowercase.");
                        break;

                    case "7":
                        editor.AddLineBreak();
                        Console.WriteLine("Line break added.");
                        break;

                    case "8":
                        editor.ClearText();
                        Console.WriteLine("Text cleared.");
                        break;

                    case "9":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
