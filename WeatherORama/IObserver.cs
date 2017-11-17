using System;

namespace WeatherORama
{
    public interface IObserver 
    {
        void update(float temp, float humidity, float pressure);
    }
}