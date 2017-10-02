using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DecreaseFanSpeed : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Fan speed decreased");
        }
    }
}
