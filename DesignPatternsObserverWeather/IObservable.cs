using System;
namespace DesignPatternsObserverWeather
{
    public interface IObservable
    {
        IDisposable Subscribe(IObserver observer);
    }
}
