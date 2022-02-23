using System;

namespace DesignPatternsObserverWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentConditionsDisplay display = new CurrentConditionsDisplay();
            WeatherData wd = new WeatherData();

            var swd = wd.Subscribe(display);

            wd.SetMeasurements(10, 10, 10);
            wd.MeasurementsChanged();

            display.Display();

            wd.SetMeasurements(11, 11, 11);

            display.Display();

            swd.Dispose();

            wd.SetMeasurements(15, 15, 15);

            display.Display();
        }
    }
}
