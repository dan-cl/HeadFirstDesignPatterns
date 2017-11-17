using System;

namespace WeatherORama
{
    class Program
    {
        static void Main(string[] args)
        {
           WeatherData weatherData = new WeatherData();

           CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        //    StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        //    ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

           weatherData.setMeasurements(80, 65, 30);
           weatherData.setMeasurements(82, 70, 29);
           weatherData.setMeasurements(78, 90, 29);
        }
    }
}
