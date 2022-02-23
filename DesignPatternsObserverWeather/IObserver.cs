using System;
namespace DesignPatternsObserverWeather
{
    public interface IObserver
    {
        void Update(WeatherData wd);     
    }
}
