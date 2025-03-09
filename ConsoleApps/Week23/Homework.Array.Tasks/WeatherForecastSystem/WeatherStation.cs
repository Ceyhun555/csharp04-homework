namespace Homework.Array.Tasks.WeatherForecastSystem
{
    class WeatherStation
    {
        private WeatherData[] data = new WeatherData[7];

        public WeatherStation(double[] temperatures)
        {
            for (int i = 0; i < 7; i++)
            {
                data[i] = new WeatherData(i + 1, temperatures[i]);
            }
        }


        public WeatherData GetHottestDay()
        {
            WeatherData hottest = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].Temperature > hottest.Temperature)
                {
                    hottest = data[i];
                }
            }
            return hottest;
        }


        public WeatherData GetColdestDay()
        {
            WeatherData coldest = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].Temperature < coldest.Temperature)
                {
                    coldest = data[i];
                }
            }
            return coldest;
        }


        public double GetAverageTemperature()
        {
            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i].Temperature;
            }
            return sum / data.Length;
        }

        public void SortByTemperature()
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i].Temperature > data[j].Temperature)
                    {
                        WeatherData temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }


        public void DisplayWeatherData()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Day {data[i].Day}: {data[i].Temperature}°C");
            }
        }
    }

}
