namespace Shared
{
    public static class DateTimeExtensions
    {
        public static int GetAge(this DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}
