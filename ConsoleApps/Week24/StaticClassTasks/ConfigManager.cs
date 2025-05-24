namespace StaticClassTasks
{
    public static class ConfigManager
    {
        public static readonly string ApplicationName = "MyApp";

        public static readonly string Version = "1.0.0";

        public static void Reload()
        {
            Console.WriteLine("Configuration reloaded successfully.");
        }
    }





}
