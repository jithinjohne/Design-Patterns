using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherPayload : IWeatherPayload
    {
        private decimal currentTemperature;

        public WeatherPayload(decimal currentTemperature)
        {
            this.currentTemperature = currentTemperature;
        }
        public decimal CurrentTemprature => currentTemperature;
    }
}
