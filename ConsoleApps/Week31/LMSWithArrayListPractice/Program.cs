using LMSWithArrayListPractice.Managers;

namespace LMSWithArrayListPractice
{
    internal class Program
    {
       
            private static AuthenticationManager _authenticationManager;
            private static LibraryManager _libraryManager;

            static void Main(string[] args)
            {              

                InitializeSystem();

                // Attempt user login with proper error handling
                if (!_authenticationManager.Login())
                {
                    Console.WriteLine("Login failed. Exiting program");
                    return;
                }

                // Start the main application menu after successful authentication
                RunMainMenu();
            }

            private static void InitializeSystem()
            {
                _authenticationManager = new AuthenticationManager();
                _libraryManager = new LibraryManager();
            }

            private static void RunMainMenu()
            {
                _libraryManager.RunMainMenu();
            }
        }
    }

