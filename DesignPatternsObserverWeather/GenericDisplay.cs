using System;
using System.Collections.Generic;
using DesignPatternsObserverWeather.Displays;

namespace DesignPatternsObserverWeather
{
    public abstract class GenericDisplay : IObserver, IDisplayElement
    {
        protected WeatherData WeatherData { get; }
        
        GenericDisplay(WeatherData weatherData) => WeatherData = weatherData;

		protected float temperature;
		protected float humidity;
		protected float pressure;

		public GenericDisplay()
        {
        }

        public abstract void Update(WeatherData weatherData);
		public abstract void Display();
	}

}