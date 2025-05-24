namespace StaticClassTasks
{
    public static class DateTimeHelper
    {
        public static string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }


        public static int DaysBetween(DateTime start, DateTime end) 
        {
            return (end - start).Days;
        }
    }
    

}
