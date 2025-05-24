using FileHandling.Examples;

namespace FileHandling.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            using (var logManager = new LogFileManager("application.log"))
            {
                logManager.WriteLog("Application started");
                logManager.WriteError("Connection failed");
                Console.WriteLine($"Log size: {logManager.GetLogSize()} bytes");
            }
            Console.WriteLine();





            //Task 2:
            var backupSystem = new FileBackupSystem("backups");

            // Create a backup of "important.txt"
            backupSystem.CreateBackup("important.txt");

            // List available backups
            string[] backups = backupSystem.ListBackups();

            // Restore from the first backup
            if (backups.Length > 0)
            {
                backupSystem.RestoreFromBackup(backups[0]);
            }
            Console.WriteLine();




            //Task 3:
            using (var monitor = new DirectoryMonitor("watchFolder"))
            {
                monitor.StartMonitoring();
                Console.WriteLine("Monitoring started. Press any key to stop...");
                Console.ReadKey();
                monitor.StopMonitoring();
            }
            Console.WriteLine();



            //Task 5:
            using (var tempManager = new TempFileManager())
            {
                string tempFile = tempManager.CreateTempFile();
                tempManager.WriteTempData("temporary content");
                Console.WriteLine($"Temp file created: {tempFile}");
            }

        }
    }
}
