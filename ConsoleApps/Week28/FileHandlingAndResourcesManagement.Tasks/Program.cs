namespace FileHandlingAndResourcesManagement.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var logManager = new LogFileManager("application-log.txt");
            try
            {
                logManager.WriteInformation("Application started.");

                logManager.WriteLog("Hello World!", LogLevel.Information);

                logManager.WriteWarning("Example warning.");

                throw new Exception();
            }
            catch (Exception ex)

            {
                var innerException = ex.InnerException != null ? ex.InnerException.Message : null;
                var message = $"{ex.Message} InnerException: {innerException ?? string.Empty}";
                logManager.WriteError(message);

                
            }

            Person person = null;

            

            //if (person == null)
            //{
            //    logger.WriteWarning("Person is null here.");
            //}
            //else
            //{
            //    logger.WriteInformation("Person successfully executed.");
            //    person.DisplayInfo();
            //}

           
            try
            {
                var name = person.Name;
                Console.WriteLine(name);
               
            }
            catch (Exception ex)
            {
                var innerException = ex.InnerException != null ? ex.InnerException.Message : null;
                var message = $"{ex.Message} InnerException: {innerException ?? string.Empty} Stack Trace: {ex.StackTrace} Source : {ex.Source}";
                logManager.WriteError(message);
                Console.WriteLine("Xəta baş verdi.");
                
            }
            Console.ReadLine();
            
        }
    }
}
