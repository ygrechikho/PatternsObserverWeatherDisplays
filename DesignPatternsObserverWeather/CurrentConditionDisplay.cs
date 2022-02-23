using System;
using DesignPatternsObserverWeather.Displays;

namespace DesignPatternsObserverWeather
{
	public class CurrentConditionsDisplay : GenericDisplay
	{
        public CurrentConditionsDisplay()
        {
        }

        public CurrentConditionsDisplay(WeatherData weatherData, float temperature, float humidity)
		{
			this.temperature = temperature;
			this.humidity = humidity;

			weatherData.Notify();
		}

		public override void Display()
		{
			Console.WriteLine("Current conditions: " + temperature +
				"F degrees and " + humidity + "% humidity");
		}

		public override void Update(WeatherData weatherData)
		{
			this.temperature = weatherData.GetTemperature();
			this.humidity = weatherData.GetHumidity();
		}
	}
}