using PhoneBookManagementSystem.Constants;
using PhoneBookManagementSystem.Interfaces;
using PhoneBookManagementSystem.Services;

namespace PhoneBookManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Set up dependency injection (Simple DI pattern)
                // Create concrete implementations of all interfaces
                IValidator validator = new ContactValidator();
                IPhoneBookRepository repository = new PhoneBookRepository(validator);
                IUserInterface userInterface = new ConsoleUserInterface(validator);

                // Use centralized constant for file path
                string filePath = ApplicationConstants.DefaultFileName;

                // Create the phone book service with all dependencies injected
                var phoneBookService = new PhoneBookService(repository, userInterface, validator, filePath);

                // Initialize the application (load existing contacts from file)
                phoneBookService.Initialize();

                // Start the main application loop
                phoneBookService.Run();
            }
            catch (Exception ex)
            {
                // Handle any fatal errors that occur during application startup or execution
                // Display error message to user
                Console.WriteLine(string.Format(ApplicationConstants.FatalError, ex.Message));

                // Wait for user acknowledgment before exiting
                Console.WriteLine(ApplicationConstants.PressAnyKeyMessage);
                Console.ReadKey();
            }
        }
    }
}
