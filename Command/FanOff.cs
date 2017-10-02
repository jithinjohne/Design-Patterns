using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class FanOff : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Fan is OFF");
        }
    }
}
