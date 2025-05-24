

using Shared;

namespace StaticClassTasks
{
    public static class Logger
    {
        public static bool EnableLogging { get; set; } = true;

        public static void DateTimeFormats(string message)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
        }

        public static void Log(string v)
        {
            if (EnableLogging)
            {
                Console.WriteLine($"[{DateTime.Now.GetDateTimeFormats()}]");
            }
        }


        public static void Error(string message) 
        {
            if (EnableLogging) 
            {
                Console.WriteLine($"[{DateTime.Now.GetDateTimeFormats()}]");
            }
        }



    }



}
