﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DecreaseBrightness : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Light is dimmer");
        }
    }
}
