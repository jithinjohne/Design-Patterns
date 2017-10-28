using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class CellPhone : IObserver
    {
        public void OnNotify(IWeatherPayload payload)
        {
            Console.WriteLine($"** cell phone ** weather update --- {payload.CurrentTemprature}");
        }
    }
}
