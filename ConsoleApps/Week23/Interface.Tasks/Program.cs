using Interface.Tasks.LoggingSystem;

namespace Interface.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();

            consoleLogger.LogInformation("Application started.");

            consoleLogger.LogWarning("Low memory warning.");

            consoleLogger.LogError("Application crash detected.");




            consoleLogger.LogInformation("Ceyhun logged to system.");

            consoleLogger.LogWarning("Disk space running low.");

            consoleLogger.LogError("Permission denided.");


            string[] latestLogMessage = consoleLogger.GetLatestLogs(2);
            foreach (string log in latestLogMessage)
            {
                Console.WriteLine(log);
            }
        }
    }



   



}
