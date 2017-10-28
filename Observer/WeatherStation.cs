using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherStation : IObservable
    {
        private IList<IObserver> observers;
        private IWeatherPayload currentWeather;

        public WeatherStation()
        {
            this.observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                return;
            }
            else
            {
                observers.Add(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.OnNotify(currentWeather);
            }
        }

        public void Remove(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
            else
            {
                return;
            }
        }

        public void SetCurrentWeather(IWeatherPayload currentWeather)
        {
            this.currentWeather = currentWeather;
            this.Notify();
        }
    }
}
