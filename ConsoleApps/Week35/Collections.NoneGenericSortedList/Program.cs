using Collections.NoneGenericSortedList.Enums;
using Collections.NoneGenericSortedList.Services;
namespace PhoneBookManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactService service = new ContactService();
            service.LoadContacts();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Phone Book Management System ===");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Update contact");
                Console.WriteLine("3. Search contact by name");
                Console.WriteLine("4. View all contacts");
                Console.WriteLine("5. Delete contact");
                Console.WriteLine("6. Save and exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();

                int choice;

                if (int.TryParse(input, out choice))
                    continue;

                switch ((MenuOption)choice)
                {
                    case MenuOption.Add:
                        service.Add();
                        break;
                    case MenuOption.Update:
                        service.Update();
                        break;
                    case MenuOption.View:
                        service.View();
                        break;
                    case MenuOption.Delete:
                        service.Delete();
                        break;
                    case MenuOption.SaveAndExit:
                        service.Save();
                        break;





                }







            }
        }
    }
}
