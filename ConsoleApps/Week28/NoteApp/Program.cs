using NoteApp.Application.Services;
using NoteApp.Aplication.Interfaces;
using NoteApp.Infrastructure;

IFileService fileService = new FileService();
INoteService noteService = new NoteService(fileService);
bool running = true;

while (running)
{
    Console.WriteLine("\n📘 Note Manager");
    Console.WriteLine("1. Add Note");
    Console.WriteLine("2. View Notes");
    Console.WriteLine("3. Delete All Notes");
    Console.WriteLine("0. Exit");
    Console.Write("Select an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            noteService.Create(title, content);
            Console.WriteLine("Note saved!");
            break;

        case "2":
            Console.WriteLine("\nYour Notes:");
            Console.WriteLine(noteService.GetAll());
            break;

        case "3":
            noteService.Clear();
            Console.WriteLine("All notes deleted.");
            break;

        case "0":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}