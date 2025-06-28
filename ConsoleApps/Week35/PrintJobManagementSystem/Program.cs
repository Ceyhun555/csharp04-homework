using PrintJobManagementSystem.Services;

namespace PrintJobManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintQueueService service = new PrintQueueService();
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Print Job Management System ===");
                Console.WriteLine("1. Add new print job");
                Console.WriteLine("2. Process next print job");
                Console.WriteLine("3. View all pending jobs");
                Console.WriteLine("4. Show estimated wait time");
                Console.WriteLine("5. Clear print queue");
                Console.WriteLine("6. Save and exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        service.AddJob();
                        break;
                    case 2:
                        service.ProcessNextJob();
                        break;
                    case 3:
                        service.ViewPendingJobs();
                        break;
                    case 4:
                        service.ShowEstimatedWaitTime();
                        break;
                    case 5:
                        service.ClearQueue();
                        break;
                    case 6:
                        service.SaveAndExit();
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            while (choice != 6);
        }
    }
}
