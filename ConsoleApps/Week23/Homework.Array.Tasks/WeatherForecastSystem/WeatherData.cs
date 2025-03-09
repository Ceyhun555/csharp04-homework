namespace Homework.Array.Tasks.WeatherForecastSystem
{
    class WeatherData
    {
        public int Day { get; set; }
        public double Temperature { get; set; }

        public WeatherData(int day, double temperature)
        {
            Day = day;
            Temperature = temperature;
        }
    }

}
