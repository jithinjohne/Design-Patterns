using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class TV : IObserver
    {
        public void OnNotify(IWeatherPayload payload)
        {
            Console.WriteLine($"** from TV ** updated weather is ---- {payload.CurrentTemprature}");
        }
    }
}
