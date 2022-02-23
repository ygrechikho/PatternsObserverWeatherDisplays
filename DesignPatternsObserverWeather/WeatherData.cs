using System;
using System.Collections.Generic;

namespace DesignPatternsObserverWeather
{
    public class WeatherData : IObservable
    {
        protected float temperature;
        protected float humidity;
        protected float pressure;

        private readonly IList<IObserver> _observers = new List<IObserver>();

        public IDisposable Subscribe(IObserver observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(this, observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void MeasurementsChanged()
        {
            Notify();
        }

        public void SetMeasurements(float temperature, float humidity,
            float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        private class Unsubscriber : IDisposable
        {
            private readonly IObserver _observer;
            private readonly WeatherData _weatherDataListener;

            public Unsubscriber(WeatherData weatherData, IObserver observer)
            {
                _observer = observer;
                _weatherDataListener = weatherData;
            }

            public void Dispose()
            {
                _weatherDataListener._observers.Remove(_observer);
            }
        }
    }
}

