﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class IncreaseFanSpeed : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Fan speed increased");
        }
    }
}
